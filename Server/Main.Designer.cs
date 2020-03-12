namespace Coursework
{
   partial class Main
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
         this.startBtn = new System.Windows.Forms.Button();
         this.stopBtn = new System.Windows.Forms.Button();
         this.ipTbx = new System.Windows.Forms.TextBox();
         this.portTbx = new System.Windows.Forms.TextBox();
         this.ipLbl = new System.Windows.Forms.Label();
         this.portLbl = new System.Windows.Forms.Label();
         this.serverGrp = new System.Windows.Forms.GroupBox();
         this.urlLbl = new System.Windows.Forms.Label();
         this.urlTbx = new System.Windows.Forms.TextBox();
         this.sendBtn = new System.Windows.Forms.Button();
         this.customMsgTbx = new System.Windows.Forms.TextBox();
         this.serverGrp.SuspendLayout();
         this.SuspendLayout();
         // 
         // startBtn
         // 
         this.startBtn.Location = new System.Drawing.Point(22, 139);
         this.startBtn.Name = "startBtn";
         this.startBtn.Size = new System.Drawing.Size(77, 32);
         this.startBtn.TabIndex = 0;
         this.startBtn.Text = "Start";
         this.startBtn.UseVisualStyleBackColor = true;
         this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
         // 
         // stopBtn
         // 
         this.stopBtn.Location = new System.Drawing.Point(22, 186);
         this.stopBtn.Name = "stopBtn";
         this.stopBtn.Size = new System.Drawing.Size(77, 30);
         this.stopBtn.TabIndex = 1;
         this.stopBtn.Text = "Stop";
         this.stopBtn.UseVisualStyleBackColor = true;
         this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
         // 
         // ipTbx
         // 
         this.ipTbx.Location = new System.Drawing.Point(105, 37);
         this.ipTbx.Name = "ipTbx";
         this.ipTbx.Size = new System.Drawing.Size(177, 22);
         this.ipTbx.TabIndex = 2;
         this.ipTbx.Text = "127.0.0.1";
         // 
         // portTbx
         // 
         this.portTbx.Location = new System.Drawing.Point(105, 71);
         this.portTbx.Name = "portTbx";
         this.portTbx.Size = new System.Drawing.Size(76, 22);
         this.portTbx.TabIndex = 3;
         this.portTbx.Text = "2055";
         // 
         // ipLbl
         // 
         this.ipLbl.AutoSize = true;
         this.ipLbl.Location = new System.Drawing.Point(15, 40);
         this.ipLbl.Name = "ipLbl";
         this.ipLbl.Size = new System.Drawing.Size(84, 17);
         this.ipLbl.TabIndex = 4;
         this.ipLbl.Text = "IP Address: ";
         // 
         // portLbl
         // 
         this.portLbl.AutoSize = true;
         this.portLbl.Location = new System.Drawing.Point(57, 74);
         this.portLbl.Name = "portLbl";
         this.portLbl.Size = new System.Drawing.Size(42, 17);
         this.portLbl.TabIndex = 5;
         this.portLbl.Text = "Port: ";
         // 
         // serverGrp
         // 
         this.serverGrp.Controls.Add(this.urlLbl);
         this.serverGrp.Controls.Add(this.urlTbx);
         this.serverGrp.Controls.Add(this.sendBtn);
         this.serverGrp.Controls.Add(this.customMsgTbx);
         this.serverGrp.Controls.Add(this.ipLbl);
         this.serverGrp.Controls.Add(this.stopBtn);
         this.serverGrp.Controls.Add(this.portLbl);
         this.serverGrp.Controls.Add(this.startBtn);
         this.serverGrp.Controls.Add(this.ipTbx);
         this.serverGrp.Controls.Add(this.portTbx);
         this.serverGrp.Location = new System.Drawing.Point(12, 12);
         this.serverGrp.Name = "serverGrp";
         this.serverGrp.Size = new System.Drawing.Size(371, 295);
         this.serverGrp.TabIndex = 6;
         this.serverGrp.TabStop = false;
         this.serverGrp.Text = "#Server";
         // 
         // urlLbl
         // 
         this.urlLbl.AutoSize = true;
         this.urlLbl.Location = new System.Drawing.Point(6, 257);
         this.urlLbl.Name = "urlLbl";
         this.urlLbl.Size = new System.Drawing.Size(40, 17);
         this.urlLbl.TabIndex = 10;
         this.urlLbl.Text = "URL:";
         // 
         // urlTbx
         // 
         this.urlTbx.Location = new System.Drawing.Point(52, 254);
         this.urlTbx.Multiline = true;
         this.urlTbx.Name = "urlTbx";
         this.urlTbx.Size = new System.Drawing.Size(313, 26);
         this.urlTbx.TabIndex = 9;
         this.urlTbx.Text = "http://localhost/";
         this.urlTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // sendBtn
         // 
         this.sendBtn.Location = new System.Drawing.Point(311, 222);
         this.sendBtn.Name = "sendBtn";
         this.sendBtn.Size = new System.Drawing.Size(54, 23);
         this.sendBtn.TabIndex = 8;
         this.sendBtn.Text = "Send";
         this.sendBtn.UseVisualStyleBackColor = true;
         this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
         // 
         // customMsgTbx
         // 
         this.customMsgTbx.Enabled = false;
         this.customMsgTbx.Location = new System.Drawing.Point(6, 222);
         this.customMsgTbx.Multiline = true;
         this.customMsgTbx.Name = "customMsgTbx";
         this.customMsgTbx.Size = new System.Drawing.Size(299, 26);
         this.customMsgTbx.TabIndex = 7;
         this.customMsgTbx.Text = "[Send Custom Response]";
         this.customMsgTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.customMsgTbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customMsgTbx_MouseDown);
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(395, 315);
         this.Controls.Add(this.serverGrp);
         this.Name = "Main";
         this.Text = "Web Communication";
         this.serverGrp.ResumeLayout(false);
         this.serverGrp.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button startBtn;
      private System.Windows.Forms.Button stopBtn;
      private System.Windows.Forms.TextBox ipTbx;
      private System.Windows.Forms.TextBox portTbx;
      private System.Windows.Forms.Label ipLbl;
      private System.Windows.Forms.Label portLbl;
      private System.Windows.Forms.GroupBox serverGrp;
      private System.Windows.Forms.TextBox customMsgTbx;
      private System.Windows.Forms.Button sendBtn;
      private System.Windows.Forms.Label urlLbl;
      private System.Windows.Forms.TextBox urlTbx;
   }
}

