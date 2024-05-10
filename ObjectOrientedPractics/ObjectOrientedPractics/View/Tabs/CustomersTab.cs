using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Control;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Model.Customers> _customers ;        
        private string _fullname;        
        private Address _address ;
        public List<Model.Customers> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                updateCustomerBox(value);
                _customers = value;
            }
        }
        public CustomersTab()
        {
            InitializeComponent();
            
        }        
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {                
                if (CustomersListBox.SelectedIndex != -1)
                {
                    int index = CustomersListBox.SelectedIndex;
                    _customers[index].Fullname = _fullname;
                    _address = addressControl2.GetAddress;
                    _customers[index].Address = _address;
                    CustomersListBox.Items[index] = _fullname;
                }
                else
                {
                    _address = addressControl2.GetAddress;
                    Model.Customers newCustomer = new Model.Customers(_fullname, _address);
                    newCustomer.IsPriority = checkBox_IsPriority.Checked;
                    _customers.Add(newCustomer);                    
                    CustomersListBox.Items.Add(newCustomer.Fullname);


                }
                ClearInputs();                
                CustomersListBox.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = ex.Message;
                ErrorLabel.Visible = true;
            }
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                _customers.RemoveAt(index);
                CustomersListBox.Items.RemoveAt(index);                
                ClearInputs();
            }
        }
               

        private void FullNameTexBox_Leave(object sender, EventArgs e)
        {
            _fullname = FullNameTexBox.Text;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int index = CustomersListBox.SelectedIndex;
                discountListBox.Items.Clear();
                IdTextBox.Text = _customers[index].Id.ToString();
                FullNameTexBox.Text = _customers[index].Fullname;
                addressControl2.SetAddress = _customers[index].Address;
                _fullname = FullNameTexBox.Text;
                checkBox_IsPriority.Checked = _customers[index].IsPriority;
                for (int i = 0; i < _customers[index].Discounts.Count;i++)
                {
                    discountListBox.Items.Add(_customers[index].Discounts[i].Info);
                }               
                ErrorLabel.Visible = false;
            }
        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            FullNameTexBox.Text = "";                      
            ErrorLabel.Visible = false;
            _fullname = "";
            addressControl2.ClearTexBox();
            discountListBox.Items.Clear();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Model.Customers newCustomer = CustomerFactory.GenerateCustomer(_customers);
            _customers.Add(newCustomer);            
            CustomersListBox.Items.Add(newCustomer.Fullname);
        }

        private void updateCustomerBox(List<Model.Customers> newCustomers)
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.SelectedIndex = -1;
            ClearInputs();
            for (int i = 0; i < newCustomers.Count; i++)
            {
                CustomersListBox.Items.Add(newCustomers[i].Fullname);
            }
        }

        private void checkBox_IsPriority_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                _customers[CustomersListBox.SelectedIndex].IsPriority= checkBox_IsPriority.Checked;
            }
        }

        private void discountAddButton_Click(object sender, EventArgs e)
        {
            var form = new AddDiscountForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {                
                int index = CustomersListBox.SelectedIndex;
                Category category = form.Category;
                _customers[index].Discounts.Add(new PercentDiscount(category));

                discountListBox.Items.Clear();
                for (int i = 0; i < _customers[index].Discounts.Count; i++)
                {
                    discountListBox.Items.Add(_customers[index].Discounts[i].Info);
                }               
                
                
            }
        }

        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != 0)
            {
                if (discountListBox.SelectedIndex != 0)
                {
                    _customers[CustomersListBox.SelectedIndex].Discounts.RemoveAt(discountListBox.SelectedIndex);
                    discountListBox.Items.Clear();
                    for (int i = 0; i < _customers[CustomersListBox.SelectedIndex].Discounts.Count; i++)
                    {
                        discountListBox.Items.Add(_customers[CustomersListBox.SelectedIndex].Discounts[i].Info);
                    }
                }
            }
            
        }
    }
}
