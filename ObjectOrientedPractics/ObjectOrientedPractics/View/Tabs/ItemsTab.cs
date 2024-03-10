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

        private List<Item> _items ;
        private string _name;
        private string _info;
        private string _cost;
        private Category _itemCategory;

        public List<Item> Items 
        { 
            get 
            {
                return _items;
            }
            set 
            {
                updateListBox(value);
                _items = value;                
            } 
        }
        public ItemsTab()
        {
            InitializeComponent();
            Items = new List<Item>();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
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
                        if (ItemsListBox.SelectedIndex != -1)
                        {
                            int index = ItemsListBox.SelectedIndex;                            
                            _items[index].Name = _name;
                            _items[index].Info = _info;
                            _items[index].Cost = floatValue;
                            _items[index].ItemCategory = _itemCategory;
                            ItemsListBox.Items[index] = _name;

                        }
                        else
                        {
                            Item newItem = new Item(_name, _info, floatValue , _itemCategory);
                            _items.Add(newItem);
                            ItemsListBox.Items.Add(newItem.Name);                            
                            
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
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _name = NameTextBox.Text;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _info = DescriptionTextBox.Text;
        }
        
        private void CostTexBox_TextChanged(object sender, EventArgs e)
        {
            _cost = CostTexBox.Text;
        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CostTexBox.Text = "";
            ErrorLabel.Visible = false;
            CategoryComboBox.SelectedIndex = -1;
            _name = "";
            _info = "";
            _cost = "";
            _itemCategory = Category.None;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int index = ItemsListBox.SelectedIndex;
                IdTextBox.Text = _items[index].Id.ToString();
                NameTextBox.Text = _items[index].Name;
                DescriptionTextBox.Text = _items[index].Info;
                CostTexBox.Text = _items[index].Cost.ToString();
                CategoryComboBox.SelectedIndex = ((int)_items[index].ItemCategory);
                _name = NameTextBox.Text;
                _info = DescriptionTextBox.Text;
                _cost = CostTexBox.Text;
                _itemCategory = (Category)CategoryComboBox.SelectedItem;
                ErrorLabel.Visible = false;
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

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GenerateItem(_items);
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem.Name);            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                _itemCategory = (Category)CategoryComboBox.SelectedItem;
            }                
        }

        private void updateListBox(List<Item> newitems)
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.SelectedIndex = -1;
            ClearInputs();
            for(int i = 0; i < newitems.Count; i++)
            {
                ItemsListBox.Items.Add(newitems[i].Name);
            }
        }

    }
}
