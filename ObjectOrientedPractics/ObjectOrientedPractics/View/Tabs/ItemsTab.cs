using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {

        private List<Item> _items;
        private List<Item> _displayedItems;
        private string _name;
        private string _info;
        private string _cost;
        private Category _itemCategory;
        private DataTools.CompareProperties SortCompare { get; set; }
        private Predicate<Item> FilterCompare { get; set; }

        public event EventHandler<EventArgs> ItemsChanged;

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                UpdateDisplayedItems();
                _items = value;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public List<Item> DisplayedItems
        {
            get => _displayedItems;
            set
            {
                _displayedItems = value;

                if (DisplayedItems != null)
                {
                    updateListBox();
                }
            }
        }
        public ItemsTab()
        {
            InitializeComponent();
            Items = new List<Item>();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            OrderByComboBox.SelectedIndex = 0;
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
                            UpdateDisplayedItems();
                        }
                        else
                        {
                            Item newItem = new Item(_name, _info, floatValue , _itemCategory);
                            _items.Add(newItem);
                            ItemsListBox.Items.Add(newItem.Name); 
                            UpdateDisplayedItems();
                            
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
                IdTextBox.Text = _displayedItems[index].Id.ToString();
                NameTextBox.Text = _displayedItems[index].Name;
                DescriptionTextBox.Text = _displayedItems[index].Info;
                CostTexBox.Text = _displayedItems[index].Cost.ToString();
                CategoryComboBox.SelectedIndex = ((int)_displayedItems[index].ItemCategory);
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
                UpdateDisplayedItems();
            }

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GenerateItem(_items);
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem.Name);
            UpdateDisplayedItems();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                _itemCategory = (Category)CategoryComboBox.SelectedItem;
            }
        }

        private void updateListBox()
        {
            //ItemsListBox.Items.Clear();
            //ItemsListBox.SelectedIndex = -1;


            var selectedItem = ItemsListBox.SelectedItem;
            ItemsListBox.Items.Clear();
            //ClearInputs();

            foreach (var item in DisplayedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }

            ItemsListBox.SelectedItem = selectedItem;

        }
        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            if (FilterCompare != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterCompare);
            }

            if (SortCompare != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortCompare);
            }

            DisplayedItems = displayedItems;
            //SetTextBoxes();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0)
            {
                FilterCompare = null;
            }
            else
            {
                FilterCompare = (item) => { return item.Name.Contains(FindTextBox.Text); };
            }

            UpdateDisplayedItems();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Name.CompareTo(secondItem.Name) < 0;
                        };

                        break;
                    }
                case 1:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Cost.CompareTo(secondItem.Cost) < 0;
                        };

                        break;
                    }
                case 2:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Cost.CompareTo(secondItem.Cost) > 0;
                        };

                        break;
                    }
            }

            var selectedItem = ItemsListBox.SelectedItem;
            UpdateDisplayedItems();
        }
    }
    
}
