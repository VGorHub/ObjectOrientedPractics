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
                    _address = addressControl1.GetAddress;
                    _customers[index].Address = _address;
                    CustomersListBox.Items[index] = _fullname;
                }
                else
                {
                    _address = addressControl1.GetAddress;
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
                IdTextBox.Text = _customers[index].Id.ToString();
                FullNameTexBox.Text = _customers[index].Fullname;
                addressControl1.SetAddress = _customers[index].Address;
                _fullname = FullNameTexBox.Text;
                checkBox_IsPriority.Checked = _customers[index].IsPriority;


                ErrorLabel.Visible = false;
            }
        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            FullNameTexBox.Text = "";                      
            ErrorLabel.Visible = false;
            _fullname = "";
            addressControl1.ClearTexBox();
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
    }
}
