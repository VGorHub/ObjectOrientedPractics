using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.View.Control;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ItemsTab itemsTab = new ItemsTab();
            CustomersTab customersTab = new CustomersTab();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;

            itemsTab.Dock = DockStyle.Fill;
            customersTab.Dock = DockStyle.Fill;

            TabControl.TabPages[0].Controls.Add(itemsTab);
            TabControl.TabPages[1].Controls.Add(customersTab);  
        }
    }
}
