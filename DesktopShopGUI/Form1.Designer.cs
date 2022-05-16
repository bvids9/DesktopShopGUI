namespace CarShopGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create_item = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_cartremove = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_create_item);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.txt_Make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Product";
            // 
            // btn_create_item
            // 
            this.btn_create_item.Location = new System.Drawing.Point(68, 198);
            this.btn_create_item.Name = "btn_create_item";
            this.btn_create_item.Size = new System.Drawing.Size(119, 23);
            this.btn_create_item.TabIndex = 6;
            this.btn_create_item.Text = "Create Item";
            this.btn_create_item.UseVisualStyleBackColor = true;
            this.btn_create_item.Click += new System.EventHandler(this.btn_create_car_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(68, 152);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(127, 23);
            this.txt_Price.TabIndex = 5;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(68, 94);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(127, 23);
            this.txt_Model.TabIndex = 4;
            // 
            // txt_Make
            // 
            this.txt_Make.Location = new System.Drawing.Point(68, 30);
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.Size = new System.Drawing.Size(127, 23);
            this.txt_Make.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_inventory);
            this.groupBox2.Location = new System.Drawing.Point(278, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.HorizontalScrollbar = true;
            this.lst_inventory.ItemHeight = 15;
            this.lst_inventory.Location = new System.Drawing.Point(6, 24);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(174, 334);
            this.lst_inventory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_cart);
            this.groupBox3.Location = new System.Drawing.Point(564, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 291);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // lst_cart
            // 
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.HorizontalScrollbar = true;
            this.lst_cart.ItemHeight = 15;
            this.lst_cart.Location = new System.Drawing.Point(6, 24);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(174, 259);
            this.lst_cart.TabIndex = 0;
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.Location = new System.Drawing.Point(471, 197);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(87, 23);
            this.btn_addtocart.TabIndex = 7;
            this.btn_addtocart.Text = "Add Item ->";
            this.btn_addtocart.UseVisualStyleBackColor = true;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(618, 381);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(79, 23);
            this.btn_checkout.TabIndex = 8;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Cost:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(647, 355);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(34, 15);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "$0.00";
            // 
            // btn_cartremove
            // 
            this.btn_cartremove.Location = new System.Drawing.Point(471, 226);
            this.btn_cartremove.Name = "btn_cartremove";
            this.btn_cartremove.Size = new System.Drawing.Size(87, 23);
            this.btn_cartremove.TabIndex = 11;
            this.btn_cartremove.Text = "<- Remove Car";
            this.btn_cartremove.UseVisualStyleBackColor = true;
            this.btn_cartremove.Click += new System.EventHandler(this.btn_cartremove_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(323, 418);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(87, 23);
            this.btn_deleteItem.TabIndex = 7;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.btn_cartremove);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_addtocart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Desktop Shopping App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_create_item;
        private TextBox txt_Price;
        private TextBox txt_Model;
        private TextBox txt_Make;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox lst_inventory;
        private GroupBox groupBox3;
        private ListBox lst_cart;
        private Button btn_addtocart;
        private Button btn_checkout;
        private Label label4;
        private Label lbl_price;
        private Button btn_cartremove;
        private Button btn_deleteItem;
    }
}