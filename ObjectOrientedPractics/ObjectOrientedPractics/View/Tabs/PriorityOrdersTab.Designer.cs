namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Control.AddressControl();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.button_RemoveItem = new System.Windows.Forms.Button();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.label_PriorityOptions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_DeliveryTime = new System.Windows.Forms.ComboBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(81, 80);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Status.TabIndex = 31;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreated.Location = new System.Drawing.Point(81, 57);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreated.TabIndex = 30;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.Location = new System.Drawing.Point(81, 35);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selected Order";
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.Location = new System.Drawing.Point(13, 303);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(450, 160);
            this.listBox_Cart.TabIndex = 25;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Amount.Location = new System.Drawing.Point(16, 486);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(68, 24);
            this.label_Amount.TabIndex = 24;
            this.label_Amount.Text = "0 RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Order Items:";
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(7, 107);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(467, 177);
            this.addressControl1.TabIndex = 20;
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.Location = new System.Drawing.Point(365, 523);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(98, 38);
            this.buttonClearOrder.TabIndex = 34;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = true;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // button_RemoveItem
            // 
            this.button_RemoveItem.Location = new System.Drawing.Point(133, 523);
            this.button_RemoveItem.Name = "button_RemoveItem";
            this.button_RemoveItem.Size = new System.Drawing.Size(98, 38);
            this.button_RemoveItem.TabIndex = 33;
            this.button_RemoveItem.Text = "Remove Item";
            this.button_RemoveItem.UseVisualStyleBackColor = true;
            this.button_RemoveItem.Click += new System.EventHandler(this.button_RemoveItem_Click);
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(20, 523);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(98, 38);
            this.button_AddItem.TabIndex = 32;
            this.button_AddItem.Text = "Add Item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // label_PriorityOptions
            // 
            this.label_PriorityOptions.AutoSize = true;
            this.label_PriorityOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PriorityOptions.Location = new System.Drawing.Point(258, 12);
            this.label_PriorityOptions.Name = "label_PriorityOptions";
            this.label_PriorityOptions.Size = new System.Drawing.Size(93, 13);
            this.label_PriorityOptions.TabIndex = 21;
            this.label_PriorityOptions.Text = "Priority Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Delivery Time:";
            // 
            // comboBox_DeliveryTime
            // 
            this.comboBox_DeliveryTime.FormattingEnabled = true;
            this.comboBox_DeliveryTime.Items.AddRange(new object[] {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"});
            this.comboBox_DeliveryTime.Location = new System.Drawing.Point(338, 34);
            this.comboBox_DeliveryTime.Name = "comboBox_DeliveryTime";
            this.comboBox_DeliveryTime.Size = new System.Drawing.Size(100, 21);
            this.comboBox_DeliveryTime.TabIndex = 31;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AllowDrop = true;
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoEllipsis = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ErrorLabel.Location = new System.Drawing.Point(261, 107);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(210, 39);
            this.ErrorLabel.TabIndex = 35;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ErrorLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cheack Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.buttonClearOrder);
            this.Controls.Add(this.button_RemoveItem);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.comboBox_DeliveryTime);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.textBoxCreated);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_PriorityOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Cart);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressControl1);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(474, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Cart;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Control.AddressControl addressControl1;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.Button button_RemoveItem;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.Label label_PriorityOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DeliveryTime;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button button1;
    }
}
