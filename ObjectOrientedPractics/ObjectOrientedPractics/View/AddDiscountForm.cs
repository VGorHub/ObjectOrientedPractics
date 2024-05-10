using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        private Category _Category;

        public Category Category
        {
            get { return _Category; }
        }
        public AddDiscountForm()
        {
            InitializeComponent();
        }
       

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _Category = (Category)CategoryComboBox.SelectedItem;            

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
       

        private void CategoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
