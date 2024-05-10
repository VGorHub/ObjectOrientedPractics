
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemTab = new System.Windows.Forms.Panel();
            this.addressControlPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_IsPriority = new System.Windows.Forms.CheckBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.FullNameTexBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.discountListBox = new System.Windows.Forms.ListBox();
            this.discountAddButton = new System.Windows.Forms.Button();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.addressControl2 = new ObjectOrientedPractics.View.Control.AddressControl();
            this.ItemTab.SuspendLayout();
            this.addressControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTab
            // 
            this.ItemTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTab.Controls.Add(this.panel3);
            this.ItemTab.Controls.Add(this.addressControlPanel);
            this.ItemTab.Controls.Add(this.panel1);
            this.ItemTab.Controls.Add(this.panel2);
            this.ItemTab.Location = new System.Drawing.Point(3, 5);
            this.ItemTab.Name = "ItemTab";
            this.ItemTab.Size = new System.Drawing.Size(835, 608);
            this.ItemTab.TabIndex = 11;
            // 
            // addressControlPanel
            // 
            this.addressControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControlPanel.Controls.Add(this.addressControl2);
            this.addressControlPanel.Location = new System.Drawing.Point(345, 156);
            this.addressControlPanel.Name = "addressControlPanel";
            this.addressControlPanel.Size = new System.Drawing.Size(481, 215);
            this.addressControlPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.CustomersLabel);
            this.panel1.Controls.Add(this.CustomersListBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 587);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.GenerateButton);
            this.panel4.Controls.Add(this.RemoveButton);
            this.panel4.Controls.Add(this.AddButton);
            this.panel4.Location = new System.Drawing.Point(3, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 50);
            this.panel4.TabIndex = 2;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(100, 0);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 50);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(233, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 50);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 10);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(113, 25);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 19;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 48);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(333, 479);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.checkBox_IsPriority);
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.FullNameTexBox);
            this.panel2.Controls.Add(this.IdTextBox);
            this.panel2.Controls.Add(this.FullNameLabel);
            this.panel2.Controls.Add(this.IdLabel);
            this.panel2.Controls.Add(this.SelectedCustomerLabel);
            this.panel2.Location = new System.Drawing.Point(345, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 147);
            this.panel2.TabIndex = 1;
            // 
            // checkBox_IsPriority
            // 
            this.checkBox_IsPriority.AutoSize = true;
            this.checkBox_IsPriority.Location = new System.Drawing.Point(8, 114);
            this.checkBox_IsPriority.Name = "checkBox_IsPriority";
            this.checkBox_IsPriority.Size = new System.Drawing.Size(68, 17);
            this.checkBox_IsPriority.TabIndex = 11;
            this.checkBox_IsPriority.Text = "Is Priority";
            this.checkBox_IsPriority.UseVisualStyleBackColor = true;
            this.checkBox_IsPriority.CheckedChanged += new System.EventHandler(this.checkBox_IsPriority_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AllowDrop = true;
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoEllipsis = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ErrorLabel.Location = new System.Drawing.Point(228, 29);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(243, 45);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ErrorLabel.Visible = false;
            // 
            // FullNameTexBox
            // 
            this.FullNameTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTexBox.Location = new System.Drawing.Point(112, 82);
            this.FullNameTexBox.Name = "FullNameTexBox";
            this.FullNameTexBox.Size = new System.Drawing.Size(366, 29);
            this.FullNameTexBox.TabIndex = 9;
            this.FullNameTexBox.Leave += new System.EventHandler(this.FullNameTexBox_Leave);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTextBox.Location = new System.Drawing.Point(112, 45);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(110, 29);
            this.IdTextBox.TabIndex = 8;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FullNameLabel.Location = new System.Drawing.Point(4, 87);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(102, 24);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IdLabel.Location = new System.Drawing.Point(4, 50);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(32, 24);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 10);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(187, 25);
            this.SelectedCustomerLabel.TabIndex = 2;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.removeDiscountButton);
            this.panel3.Controls.Add(this.discountAddButton);
            this.panel3.Controls.Add(this.discountListBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(348, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 120);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discounts";
            // 
            // discountListBox
            // 
            this.discountListBox.FormattingEnabled = true;
            this.discountListBox.Location = new System.Drawing.Point(3, 42);
            this.discountListBox.Name = "discountListBox";
            this.discountListBox.Size = new System.Drawing.Size(307, 69);
            this.discountListBox.TabIndex = 3;
            // 
            // discountAddButton
            // 
            this.discountAddButton.Location = new System.Drawing.Point(316, 23);
            this.discountAddButton.Name = "discountAddButton";
            this.discountAddButton.Size = new System.Drawing.Size(111, 41);
            this.discountAddButton.TabIndex = 4;
            this.discountAddButton.Text = "Add";
            this.discountAddButton.UseVisualStyleBackColor = true;
            this.discountAddButton.Click += new System.EventHandler(this.discountAddButton_Click);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Location = new System.Drawing.Point(316, 70);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(111, 41);
            this.removeDiscountButton.TabIndex = 4;
            this.removeDiscountButton.Text = "Remove";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.removeDiscountButton_Click);
            // 
            // addressControl2
            // 
            this.addressControl2.Location = new System.Drawing.Point(6, 4);
            this.addressControl2.Name = "addressControl2";
            this.addressControl2.Size = new System.Drawing.Size(492, 203);
            this.addressControl2.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemTab);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(841, 619);
            this.ItemTab.ResumeLayout(false);
            this.addressControlPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox FullNameTexBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel addressControlPanel;
        private Control.AddressControl addressControl1;
        private System.Windows.Forms.CheckBox checkBox_IsPriority;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox discountListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeDiscountButton;
        private System.Windows.Forms.Button discountAddButton;
        private Control.AddressControl addressControl2;
    }
}
