namespace VehicleSalesAppWin
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create_car = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.btn_add_to_cart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lst_cart = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Make:";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(77, 87);
            this.txt_year.Margin = new System.Windows.Forms.Padding(1);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(105, 23);
            this.txt_year.TabIndex = 11;
            this.txt_year.TextChanged += new System.EventHandler(this.txt_year_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_create_car);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.txt_make);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(238, 313);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            // 
            // btn_create_car
            // 
            this.btn_create_car.Location = new System.Drawing.Point(77, 175);
            this.btn_create_car.Margin = new System.Windows.Forms.Padding(1);
            this.btn_create_car.Name = "btn_create_car";
            this.btn_create_car.Size = new System.Drawing.Size(88, 37);
            this.btn_create_car.TabIndex = 13;
            this.btn_create_car.Text = "Create a Car";
            this.btn_create_car.UseVisualStyleBackColor = true;
            this.btn_create_car.Click += new System.EventHandler(this.btn_create_car_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(77, 112);
            this.txt_price.Margin = new System.Windows.Forms.Padding(1);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(105, 23);
            this.txt_price.TabIndex = 13;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(77, 64);
            this.txt_model.Margin = new System.Windows.Forms.Padding(1);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(105, 23);
            this.txt_model.TabIndex = 13;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(77, 40);
            this.txt_make.Margin = new System.Windows.Forms.Padding(1);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(105, 23);
            this.txt_make.TabIndex = 13;
            this.txt_make.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_inventory);
            this.groupBox2.Location = new System.Drawing.Point(281, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(227, 390);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory:";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.ItemHeight = 15;
            this.lst_inventory.Location = new System.Drawing.Point(11, 18);
            this.lst_inventory.Margin = new System.Windows.Forms.Padding(1);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(200, 304);
            this.lst_inventory.TabIndex = 14;
            this.lst_inventory.SelectedIndexChanged += new System.EventHandler(this.lst_inventory_SelectedIndexChanged);
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.Location = new System.Drawing.Point(538, 200);
            this.btn_add_to_cart.Margin = new System.Windows.Forms.Padding(1);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(110, 37);
            this.btn_add_to_cart.TabIndex = 15;
            this.btn_add_to_cart.Text = "Add to cart -->";
            this.btn_add_to_cart.UseVisualStyleBackColor = true;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_total);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_checkout);
            this.groupBox3.Controls.Add(this.lst_cart);
            this.groupBox3.Location = new System.Drawing.Point(692, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(259, 395);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(140, 316);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 15);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Cost:";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(91, 259);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(1);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(77, 37);
            this.btn_checkout.TabIndex = 1;
            this.btn_checkout.Text = "Check out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lst_cart
            // 
            this.lst_cart.Location = new System.Drawing.Point(2, 35);
            this.lst_cart.Margin = new System.Windows.Forms.Padding(1);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(235, 208);
            this.lst_cart.TabIndex = 0;
            this.lst_cart.UseCompatibleStateImageBehavior = false;
            this.lst_cart.SelectedIndexChanged += new System.EventHandler(this.lst_cart_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_add_to_cart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_year;
        private GroupBox groupBox1;
        private Button btn_create_car;
        private TextBox txt_price;
        private TextBox txt_model;
        private TextBox txt_make;
        private GroupBox groupBox2;
        private ListBox lst_inventory;
        private Button btn_add_to_cart;
        private GroupBox groupBox3;
        private Label label1;
        private Button btn_checkout;
        private ListView lst_cart;
        private Label lbl_total;
        private Label label2;
    }
}