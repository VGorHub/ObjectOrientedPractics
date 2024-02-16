using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class Customers : UserControl
    {
        private int _id;
        private string _fullname;
        private string _address;
        public Customers()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer(_fullname, _address);
                if (CustomersListBox.SelectedIndex != -1)
                {
                    int index = CustomersListBox.SelectedIndex;
                    CustomersListBox.Items[index] = newCustomer;
                }
                else
                {
                    CustomersListBox.Items.Add(newCustomer);

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
                CustomersListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            _address = AddressTextBox.Text;
        }

        private void FullNameTexBox_Leave(object sender, EventArgs e)
        {
            _fullname = FullNameTexBox.Text;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                IdTextBox.Text = selectedCustomer.Id.ToString();
                FullNameTexBox.Text = selectedCustomer.Fullname;
                AddressTextBox.Text = selectedCustomer.Address;
            }
        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            FullNameTexBox.Text = "";
            AddressTextBox.Text = "";            
            ErrorLabel.Visible = false;
        }
    }
}
