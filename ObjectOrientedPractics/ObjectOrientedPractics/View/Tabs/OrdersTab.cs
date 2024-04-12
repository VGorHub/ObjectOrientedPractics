using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customers> _customers;

        private List<Order> _orders = new List<Order>();

        public List<Customers> Customers { get { return _customers; } set { _customers = value; } }
        public OrdersTab()
        {
            
            InitializeComponent();
            InitializeComboBoxStatus();            

        }
        private void InitializeComboBoxStatus()
        {
            foreach (OrderStatus c in Enum.GetValues(typeof(OrderStatus)))
            {
                comboBox_Status.Items.Add(c);
            }
        }
        private void InitializeDataGridView1()
        {
            

            foreach (var customer in Customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }
            if (_orders.Count > 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < _orders.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);


                    row.Cells[0].Value = _orders[i].Id;
                    row.Cells[1].Value = _orders[i].OrderStatus;
                    row.Cells[2].Value = _orders[i].Fullname;
                    row.Cells[3].Value = _orders[i].DeliveryAddress.City + ", " + _orders[i].DeliveryAddress.Street + ", " + _orders[i].DeliveryAddress.Building;
                    row.Cells[4].Value = _orders[i].CreationDate;
                    row.Cells[5].Value = _orders[i].Cart.Amount;


                    dataGridView1.Rows.Add(row);
                }
            }
        }
        

        public void UpdateOrders()
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_orders.Count - 1 >= dataGridView1.CurrentCell.RowIndex)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                textBox_ID.Text = _orders[index].Id.ToString();
                comboBox_Status.Text = _orders[index].OrderStatus.ToString();
                textBoxCreated.Text = _orders[index].CreationDate.ToString();
                addressControl1.SetAddress = _orders[index].DeliveryAddress;
                label_Amount.Text = _orders[index].Cart.Amount.ToString() + "RUB";
                listBox_Cart.Items.Clear();
                for (int i = 0; i < _orders[index].Cart.Items.Count; i++)
                {

                    listBox_Cart.Items.Add(_orders[index].Cart.Items[i].Name + " price:" + _orders[index].Cart.Items[i].Cost.ToString() + "RUB");
                }
            }

        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Status.SelectedIndex != -1)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                _orders[index].OrderStatus = (OrderStatus)comboBox_Status.Items[comboBox_Status.SelectedIndex];
            }
        }

        private void OrdersTab_Enter(object sender, EventArgs e)
        {
            InitializeDataGridView1();
        }
    }
}
