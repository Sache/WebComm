namespace Client
{
   partial class Inventory
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.inventoryLstvw = new System.Windows.Forms.ListView();
         this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.productTbx = new System.Windows.Forms.TextBox();
         this.customerTbx = new System.Windows.Forms.TextBox();
         this.pricetbx = new System.Windows.Forms.TextBox();
         this.datetbx = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.addorderBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // inventoryLstvw
         // 
         this.inventoryLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Customer,
            this.Price,
            this.Date});
         this.inventoryLstvw.Location = new System.Drawing.Point(12, 12);
         this.inventoryLstvw.Name = "inventoryLstvw";
         this.inventoryLstvw.Size = new System.Drawing.Size(543, 426);
         this.inventoryLstvw.TabIndex = 1;
         this.inventoryLstvw.UseCompatibleStateImageBehavior = false;
         this.inventoryLstvw.View = System.Windows.Forms.View.Details;
         // 
         // ID
         // 
         this.ID.Text = "ID";
         this.ID.Width = 36;
         // 
         // Product
         // 
         this.Product.Text = "Product";
         this.Product.Width = 142;
         // 
         // Customer
         // 
         this.Customer.Text = "Customer";
         this.Customer.Width = 154;
         // 
         // Price
         // 
         this.Price.Text = "Price";
         this.Price.Width = 86;
         // 
         // Date
         // 
         this.Date.Text = "Date";
         this.Date.Width = 113;
         // 
         // productTbx
         // 
         this.productTbx.Location = new System.Drawing.Point(634, 33);
         this.productTbx.Name = "productTbx";
         this.productTbx.Size = new System.Drawing.Size(154, 22);
         this.productTbx.TabIndex = 3;
         // 
         // customerTbx
         // 
         this.customerTbx.Location = new System.Drawing.Point(634, 88);
         this.customerTbx.Name = "customerTbx";
         this.customerTbx.Size = new System.Drawing.Size(154, 22);
         this.customerTbx.TabIndex = 4;
         // 
         // pricetbx
         // 
         this.pricetbx.Location = new System.Drawing.Point(634, 152);
         this.pricetbx.Name = "pricetbx";
         this.pricetbx.Size = new System.Drawing.Size(154, 22);
         this.pricetbx.TabIndex = 5;
         // 
         // datetbx
         // 
         this.datetbx.Location = new System.Drawing.Point(634, 207);
         this.datetbx.Name = "datetbx";
         this.datetbx.Size = new System.Drawing.Size(154, 22);
         this.datetbx.TabIndex = 6;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(567, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(61, 17);
         this.label1.TabIndex = 8;
         this.label1.Text = "Product;";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(556, 88);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(72, 17);
         this.label2.TabIndex = 9;
         this.label2.Text = "Customer:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(584, 152);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(44, 17);
         this.label3.TabIndex = 10;
         this.label3.Text = "Price:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(582, 210);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(0, 17);
         this.label4.TabIndex = 11;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(584, 210);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(42, 17);
         this.label5.TabIndex = 12;
         this.label5.Text = "Date:";
         // 
         // addorderBtn
         // 
         this.addorderBtn.Location = new System.Drawing.Point(634, 254);
         this.addorderBtn.Name = "addorderBtn";
         this.addorderBtn.Size = new System.Drawing.Size(101, 36);
         this.addorderBtn.TabIndex = 13;
         this.addorderBtn.Text = "Add Order";
         this.addorderBtn.UseVisualStyleBackColor = true;
         this.addorderBtn.Click += new System.EventHandler(this.addorderBtn_Click);
         // 
         // Inventory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.addorderBtn);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.datetbx);
         this.Controls.Add(this.pricetbx);
         this.Controls.Add(this.customerTbx);
         this.Controls.Add(this.productTbx);
         this.Controls.Add(this.inventoryLstvw);
         this.Name = "Inventory";
         this.Text = "Inventory";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListView inventoryLstvw;
      private System.Windows.Forms.ColumnHeader ID;
      private System.Windows.Forms.ColumnHeader Product;
      private System.Windows.Forms.ColumnHeader Customer;
      private System.Windows.Forms.ColumnHeader Price;
      private System.Windows.Forms.ColumnHeader Date;
      private System.Windows.Forms.TextBox productTbx;
      private System.Windows.Forms.TextBox customerTbx;
      private System.Windows.Forms.TextBox pricetbx;
      private System.Windows.Forms.TextBox datetbx;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button addorderBtn;
   }
}