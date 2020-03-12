namespace Client
{
   partial class GUI
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
         this.apiKeyTbx = new System.Windows.Forms.TextBox();
         this.okKeyBtn = new System.Windows.Forms.Button();
         this.usernameTbx = new System.Windows.Forms.TextBox();
         this.usernamelbl = new System.Windows.Forms.Label();
         this.newuserGrp = new System.Windows.Forms.GroupBox();
         this.addBtn = new System.Windows.Forms.Button();
         this.rankTbx = new System.Windows.Forms.TextBox();
         this.ranklbl = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.localhostTbx = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.portTbx = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.inventoryBtn = new System.Windows.Forms.Button();
         this.newuserGrp.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // apiKeyTbx
         // 
         this.apiKeyTbx.Location = new System.Drawing.Point(15, 60);
         this.apiKeyTbx.Name = "apiKeyTbx";
         this.apiKeyTbx.Size = new System.Drawing.Size(293, 22);
         this.apiKeyTbx.TabIndex = 0;
         this.apiKeyTbx.Text = "API Key";
         this.apiKeyTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // okKeyBtn
         // 
         this.okKeyBtn.Location = new System.Drawing.Point(310, 59);
         this.okKeyBtn.Name = "okKeyBtn";
         this.okKeyBtn.Size = new System.Drawing.Size(44, 23);
         this.okKeyBtn.TabIndex = 1;
         this.okKeyBtn.Text = "OK";
         this.okKeyBtn.UseVisualStyleBackColor = true;
         this.okKeyBtn.Click += new System.EventHandler(this.okKeyBtn_Click);
         // 
         // usernameTbx
         // 
         this.usernameTbx.Location = new System.Drawing.Point(89, 30);
         this.usernameTbx.Name = "usernameTbx";
         this.usernameTbx.Size = new System.Drawing.Size(153, 22);
         this.usernameTbx.TabIndex = 2;
         // 
         // usernamelbl
         // 
         this.usernamelbl.AutoSize = true;
         this.usernamelbl.Location = new System.Drawing.Point(6, 30);
         this.usernamelbl.Name = "usernamelbl";
         this.usernamelbl.Size = new System.Drawing.Size(77, 17);
         this.usernamelbl.TabIndex = 4;
         this.usernamelbl.Text = "Username:";
         // 
         // newuserGrp
         // 
         this.newuserGrp.Controls.Add(this.addBtn);
         this.newuserGrp.Controls.Add(this.rankTbx);
         this.newuserGrp.Controls.Add(this.ranklbl);
         this.newuserGrp.Controls.Add(this.usernameTbx);
         this.newuserGrp.Controls.Add(this.usernamelbl);
         this.newuserGrp.Location = new System.Drawing.Point(15, 128);
         this.newuserGrp.Name = "newuserGrp";
         this.newuserGrp.Size = new System.Drawing.Size(257, 150);
         this.newuserGrp.TabIndex = 5;
         this.newuserGrp.TabStop = false;
         this.newuserGrp.Text = "Add New Credential";
         // 
         // addBtn
         // 
         this.addBtn.Location = new System.Drawing.Point(9, 115);
         this.addBtn.Name = "addBtn";
         this.addBtn.Size = new System.Drawing.Size(81, 27);
         this.addBtn.TabIndex = 6;
         this.addBtn.Text = "Add";
         this.addBtn.UseVisualStyleBackColor = true;
         this.addBtn.Click += new System.EventHandler(this.addBtn_ClickAsync);
         // 
         // rankTbx
         // 
         this.rankTbx.Location = new System.Drawing.Point(89, 65);
         this.rankTbx.Name = "rankTbx";
         this.rankTbx.Size = new System.Drawing.Size(67, 22);
         this.rankTbx.TabIndex = 6;
         // 
         // ranklbl
         // 
         this.ranklbl.AutoSize = true;
         this.ranklbl.Location = new System.Drawing.Point(28, 65);
         this.ranklbl.Name = "ranklbl";
         this.ranklbl.Size = new System.Drawing.Size(45, 17);
         this.ranklbl.TabIndex = 5;
         this.ranklbl.Text = "Rank:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 35);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 17);
         this.label2.TabIndex = 7;
         this.label2.Text = "Server:";
         // 
         // localhostTbx
         // 
         this.localhostTbx.Location = new System.Drawing.Point(72, 32);
         this.localhostTbx.Name = "localhostTbx";
         this.localhostTbx.Size = new System.Drawing.Size(185, 22);
         this.localhostTbx.TabIndex = 7;
         this.localhostTbx.Text = "127.0.0.1";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(263, 35);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 17);
         this.label3.TabIndex = 8;
         this.label3.Text = "Port:";
         // 
         // portTbx
         // 
         this.portTbx.Location = new System.Drawing.Point(298, 32);
         this.portTbx.Name = "portTbx";
         this.portTbx.Size = new System.Drawing.Size(56, 22);
         this.portTbx.TabIndex = 9;
         this.portTbx.Text = "2055";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.portTbx);
         this.groupBox1.Controls.Add(this.apiKeyTbx);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.okKeyBtn);
         this.groupBox1.Controls.Add(this.localhostTbx);
         this.groupBox1.Location = new System.Drawing.Point(15, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(371, 110);
         this.groupBox1.TabIndex = 10;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Connect to Business Logic";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.inventoryBtn);
         this.groupBox2.Location = new System.Drawing.Point(278, 133);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(105, 145);
         this.groupBox2.TabIndex = 11;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Inventory";
         // 
         // inventoryBtn
         // 
         this.inventoryBtn.Location = new System.Drawing.Point(6, 30);
         this.inventoryBtn.Name = "inventoryBtn";
         this.inventoryBtn.Size = new System.Drawing.Size(93, 27);
         this.inventoryBtn.TabIndex = 6;
         this.inventoryBtn.Text = "View";
         this.inventoryBtn.UseVisualStyleBackColor = true;
         this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
         // 
         // GUI
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(399, 287);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.newuserGrp);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "GUI";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Access Credentials ";
         this.newuserGrp.ResumeLayout(false);
         this.newuserGrp.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox apiKeyTbx;
      private System.Windows.Forms.Button okKeyBtn;
      private System.Windows.Forms.TextBox usernameTbx;
      private System.Windows.Forms.Label usernamelbl;
      private System.Windows.Forms.GroupBox newuserGrp;
      private System.Windows.Forms.Button addBtn;
      private System.Windows.Forms.TextBox rankTbx;
      private System.Windows.Forms.Label ranklbl;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox localhostTbx;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox portTbx;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button inventoryBtn;
   }
}

