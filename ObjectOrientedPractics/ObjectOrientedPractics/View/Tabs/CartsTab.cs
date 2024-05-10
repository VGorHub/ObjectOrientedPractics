using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Customers> _customers;
        private List<Item> _items;
        private Customers _currentCustomer;
        private double totalDiscount = 0;
        private Customers CurrentCustomer 
        { 
            get { return _currentCustomer; }
            set { _currentCustomer = value; }
        }
        public List<Item> Items {  get { return _items; } set { _items = value;} }

        public List<Customers> Customers { get { return _customers; } set { _customers = value; } }
        public CartsTab()
        {
            InitializeComponent();            
        }
        private void InitializeListBoxItems()
        {
            listBox_Items.Items.Clear();
            if(_items != null)
            {
                foreach (var item in _items)
                {
                    listBox_Items.Items.Add(item.Name);
                }
            }
        }
        private void InitializeComboBoxCustomers()
        {
            comboBox_Customers.Items.Clear();
            if(_customers != null)
            {
                foreach(var customer in _customers)
                {
                    comboBox_Customers.Items.Add(customer.Fullname);
                }
            }
        }
        private void button_AddToCart_Click(object sender, EventArgs e)
        {
            if(listBox_Items.SelectedIndex == -1)
            {
                
            }
            else
            {
                if(CurrentCustomer != null)
                {
                    CurrentCustomer.Cart.Items.Add(_items[listBox_Items.SelectedIndex]);
                    UpdateListBoxCart();
                }
            }
        }        

        private void comboBox_Customers_MouseClick(object sender, MouseEventArgs e)
        {
            
        }        
        public void comboBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Customers.SelectedIndex != -1)
            {
                CurrentCustomer = _customers[comboBox_Customers.SelectedIndex];
                discountCheckedListBox.Items.Clear();
                UpdateListBoxCart();                
                
                for (int i = 0;i < CurrentCustomer.Discounts.Count; i++)
                {
                    discountCheckedListBox.Items.Add(CurrentCustomer.Discounts[i].Info);
                    discountCheckedListBox.SetItemChecked(i, true);
                }
                
            }
        } 
        private void UpdateListBoxCart()
        {
            updateDiscount();
            if (CurrentCustomer != null)
            {
                listBox_Cart.Items.Clear();
                foreach (var currentCustomerItem in CurrentCustomer.Cart.Items)
                {
                    listBox_Cart.Items.Add(currentCustomerItem.Name);
                }
                label_Amount.Text = CurrentCustomer.Cart.Amount.ToString()+ " RUB";
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            if(CurrentCustomer == null)
            {

            }
            else
            {
                listBox_Cart.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
                label_Amount.Text = CurrentCustomer.Cart.Amount.ToString() + " RUB";
            }
        }

        private void button_RemoveItem_Click(object sender, EventArgs e)
        {
            if(listBox_Cart.SelectedIndex == -1)
            {

            }
            else
            {
                if(CurrentCustomer != null)
                {                    
                    CurrentCustomer.Cart.Items.Remove(CurrentCustomer.Cart.Items[listBox_Cart.SelectedIndex]);
                    UpdateListBoxCart();
                }
                
            }
        }

        private void button_CreateOrder_Click(object sender, EventArgs e)
        {
            if(CurrentCustomer == null)
            {

            }
            else
            {
                if(listBox_Cart.Items.Count == 0)
                {

                }
                else
                {
                    Cart cart = new Cart();
                    foreach (var item in CurrentCustomer.Cart.Items)
                    {
                        cart.Items.Add(item);
                    }
                    if (CurrentCustomer.IsPriority)
                    {
                        PriorityOrder newOrder = new PriorityOrder(DateTime.Now, CurrentCustomer.Address, cart, CurrentCustomer.Fullname, DateTime.Now, WishTimeEnum.NineToEleven);
                        newOrder.DiscountAmount = totalDiscount;
                        CurrentCustomer.Orders.Add(newOrder);
                    }
                    else
                    {
                        
                        Order newOrder = new Order(DateTime.Now, CurrentCustomer.Address, cart, CurrentCustomer.Fullname);
                        newOrder.DiscountAmount = totalDiscount;
                        CurrentCustomer.Orders.Add(newOrder);
                    }

                    for (int i = 0; i < discountCheckedListBox.Items.Count; i++)
                    {

                        if (discountCheckedListBox.GetItemChecked(i))
                        {
                            CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                            CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
                        }
                    }                    
                    listBox_Cart.Items.Clear();
                    CurrentCustomer.Cart.Items.Clear();
                    label_Amount.Text = CurrentCustomer.Cart.Amount.ToString() + " RUB";
                    comboBox_Customers.SelectedIndex = -1;
                    discountCheckedListBox.Items.Clear();
                    updateDiscount();
                }
            }
        }

        private void RefreshData()
        {
            comboBox_Customers.SelectedIndex = -1;
            label_Amount.Text = "0 RUB";
            InitializeListBoxItems();
            InitializeComboBoxCustomers();
        }
        private void CartsTab_Enter(object sender, EventArgs e)
        {
            RefreshData();
        }
        
        private void updateDiscount()
        {
            totalDiscount = 0;
            for (int i = 0; i < discountCheckedListBox.Items.Count; i++)
            {
                
                if (discountCheckedListBox.GetItemChecked(i))
                {
                    totalDiscount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            discountAmountLabel.Text = totalDiscount.ToString();
            TotalLabel.Text = (CurrentCustomer.Cart.Amount - totalDiscount).ToString();
        }
        private void discountCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {

            updateDiscount();
        }

        
    }
}
