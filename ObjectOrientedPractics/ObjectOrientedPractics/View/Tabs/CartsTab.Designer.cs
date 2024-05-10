namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.discountCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.button_RemoveItem = new System.Windows.Forms.Button();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Customers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddToCart = new System.Windows.Forms.Button();
            this.listBox_Items = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TotalLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.discountAmountLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.discountCheckedListBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.listBox_Cart);
            this.panel3.Controls.Add(this.buttonClearCart);
            this.panel3.Controls.Add(this.button_RemoveItem);
            this.panel3.Controls.Add(this.button_CreateOrder);
            this.panel3.Controls.Add(this.label_Amount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox_Customers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(276, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 524);
            this.panel3.TabIndex = 0;
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(243, 398);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(0, 13);
            this.discountAmountLabel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(171, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discount Amount";
            // 
            // discountCheckedListBox
            // 
            this.discountCheckedListBox.FormattingEnabled = true;
            this.discountCheckedListBox.Location = new System.Drawing.Point(7, 369);
            this.discountCheckedListBox.Name = "discountCheckedListBox";
            this.discountCheckedListBox.Size = new System.Drawing.Size(149, 139);
            this.discountCheckedListBox.TabIndex = 14;
            this.discountCheckedListBox.SelectedValueChanged += new System.EventHandler(this.discountCheckedListBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Discounts";
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.Location = new System.Drawing.Point(3, 84);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(315, 160);
            this.listBox_Cart.TabIndex = 9;
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(220, 294);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(98, 38);
            this.buttonClearCart.TabIndex = 8;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // button_RemoveItem
            // 
            this.button_RemoveItem.Location = new System.Drawing.Point(116, 294);
            this.button_RemoveItem.Name = "button_RemoveItem";
            this.button_RemoveItem.Size = new System.Drawing.Size(98, 38);
            this.button_RemoveItem.TabIndex = 7;
            this.button_RemoveItem.Text = "Remove Item";
            this.button_RemoveItem.UseVisualStyleBackColor = true;
            this.button_RemoveItem.Click += new System.EventHandler(this.button_RemoveItem_Click);
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(3, 294);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(98, 38);
            this.button_CreateOrder.TabIndex = 6;
            this.button_CreateOrder.Text = "Create Order";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.button_CreateOrder_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Amount.Location = new System.Drawing.Point(3, 267);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(68, 24);
            this.label_Amount.TabIndex = 5;
            this.label_Amount.Text = "0 RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cart:";
            // 
            // comboBox_Customers
            // 
            this.comboBox_Customers.FormattingEnabled = true;
            this.comboBox_Customers.Location = new System.Drawing.Point(113, 32);
            this.comboBox_Customers.Name = "comboBox_Customers";
            this.comboBox_Customers.Size = new System.Drawing.Size(205, 21);
            this.comboBox_Customers.TabIndex = 1;
            this.comboBox_Customers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Customers_SelectedIndexChanged);
            this.comboBox_Customers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Customers_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_AddToCart);
            this.panel2.Controls.Add(this.listBox_Items);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 524);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // button_AddToCart
            // 
            this.button_AddToCart.Location = new System.Drawing.Point(3, 481);
            this.button_AddToCart.Name = "button_AddToCart";
            this.button_AddToCart.Size = new System.Drawing.Size(98, 38);
            this.button_AddToCart.TabIndex = 1;
            this.button_AddToCart.Text = "Add To Cart";
            this.button_AddToCart.UseVisualStyleBackColor = true;
            this.button_AddToCart.Click += new System.EventHandler(this.button_AddToCart_Click);
            // 
            // listBox_Items
            // 
            this.listBox_Items.FormattingEnabled = true;
            this.listBox_Items.Location = new System.Drawing.Point(3, 29);
            this.listBox_Items.Name = "listBox_Items";
            this.listBox_Items.Size = new System.Drawing.Size(261, 446);
            this.listBox_Items.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(236, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(243, 481);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalLabel.TabIndex = 18;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(606, 536);
            this.Enter += new System.EventHandler(this.CartsTab_Enter);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_Items;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Customers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddToCart;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button button_RemoveItem;
        private System.Windows.Forms.Button button_CreateOrder;
        private System.Windows.Forms.ListBox listBox_Cart;
        private System.Windows.Forms.CheckedListBox discountCheckedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label7;
    }
}
