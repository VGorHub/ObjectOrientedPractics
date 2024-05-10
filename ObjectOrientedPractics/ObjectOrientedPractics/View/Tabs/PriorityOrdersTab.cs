using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _priorityOrder;
        private List<Item> _items = new List<Item>();
        private Cart _cart = new Cart();
        OrderStatus _priorityOrderStatus;
        Address _address;


        public PriorityOrdersTab()
        {
            InitializeComponent();
            comboBox_DeliveryTime.SelectedIndex = 0;
            foreach (OrderStatus c in Enum.GetValues(typeof(OrderStatus)))
            {
                comboBox_Status.Items.Add(c);
            }
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GenerateItem(_items);
            _items.Add(newItem);
            listBox_Cart.Items.Add(newItem.Name);            
            _cart.Items.Add(newItem);
            label_Amount.Text = _cart.Amount.ToString() + " RUB";
        }

        private void button_RemoveItem_Click(object sender, EventArgs e)
        {
            if (listBox_Cart.SelectedIndex == -1)
            {

            }
            else
            {
                _cart.Items.Remove(_cart.Items[listBox_Cart.SelectedIndex]);
                _items.Remove(_items[listBox_Cart.SelectedIndex]);
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            listBox_Cart.Items.Clear();
            foreach (var currentCustomerItem in _items)
            {
                listBox_Cart.Items.Add(currentCustomerItem.Name);
            }
            label_Amount.Text = _cart.Amount.ToString() + " RUB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _priorityOrder.DeliveryAddress = addressControl1.GetAddress;

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
                ErrorLabel.Visible = true;
            }
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            listBox_Cart.Items.Clear();
            _cart.Items.Clear();
            label_Amount.Text = _cart.Amount.ToString() + " RUB";
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Status.SelectedIndex != -1)
            {
                _priorityOrderStatus = (OrderStatus)comboBox_Status.Items[comboBox_Status.SelectedIndex];
            }
        }
    }
}
