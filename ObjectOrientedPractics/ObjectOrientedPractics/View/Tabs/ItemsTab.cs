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
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private string _name;
        private string _info;
        private string _cost;


        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                float floatValue;
                if (float.TryParse(_cost, out floatValue))
                {
                    try
                    {
                        Item newItem = new Item(_name, _info, floatValue);
                        if (ItemsListBox.SelectedIndex != -1)
                        {
                            int index = ItemsListBox.SelectedIndex;
                            ItemsListBox.Items[index] = newItem;
                            _items[index] = newItem;
                        }
                        else
                        {
                            _items.Add(newItem);
                            ItemsListBox.Items.Add(newItem);
                            
                        }
                        ClearInputs();
                        ItemsListBox.SelectedIndex = -1;
                    }
                    catch
                    {
                        throw;
                    }
                }
                else
                {
                    throw new Exception("Не удалось преобразовать во float");
                }            
            }
            catch (Exception ex)
            {
                ErrorLabel.Text =ex.Message;
                ErrorLabel.Visible = true;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {      
            _name = NameTextBox.Text;            
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            _info = DescriptionTextBox.Text;           
        }

        private void CostTexBox_Leave(object sender, EventArgs e)
        {
            _cost = CostTexBox.Text;
        }

        private void IdTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CostTexBox.Text = "";
            ErrorLabel.Visible = false;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                IdTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                DescriptionTextBox.Text = selectedItem.Info;
                CostTexBox.Text = selectedItem.Cost.ToString();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                _items.RemoveAt(index);
                ItemsListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }
    }
}
