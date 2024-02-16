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

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ItemsTab user1 = new ItemsTab();
            Customers user2 = new Customers();
            user1.Dock = DockStyle.Fill;
            user2.Dock = DockStyle.Fill;
            TabControl.TabPages[0].Controls.Add(user1);
            TabControl.TabPages[1].Controls.Add(user2);

        }
    }
}
