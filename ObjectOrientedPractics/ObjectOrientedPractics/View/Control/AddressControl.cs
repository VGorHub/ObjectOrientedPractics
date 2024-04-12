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

namespace ObjectOrientedPractics.View.Control
{
    public partial class AddressControl : UserControl
    {
        private Address _address ;
        private bool noClear = true;

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
    }
        public Address GetAddress
        {
            get
            {
                Address _address1 = new Address(IndexTextBox.Text, CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text, ApartmentTextBox.Text);               
                             
                return _address1;               
            }
            
        }
        public Address SetAddress
        {
            set
            {
                _address = value;
                UpdateUI();                
            }
        }

        private void UpdateUI()
        {
            IndexTextBox.Text = _address.Index;
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }
        public void ClearTexBox()
        {
            IndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";           
        }

        private void IndexTextBox_Leave(object sender, EventArgs e)
        {
            
            
        }
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void СityTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
