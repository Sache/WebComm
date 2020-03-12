using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
   public partial class Main : Form
   {
      HttpListener newServer;

      public Main()
      {
         InitializeComponent();
      }

      private void startBtn_Click(object sender, EventArgs e)
      {
         try
         {
            newServer = Server.StartServer(ipTbx.Text, portTbx.Text);
            Task.Factory.StartNew(() => 
            {
               Server.CommandHandler(newServer);
            });
         } catch (Exception ex)
         {
            MessageBox.Show("Error:" + ex);
         }

         if (!String.IsNullOrEmpty(urlTbx.Text))
         {
            bool isUri = Uri.IsWellFormedUriString(urlTbx.Text, UriKind.RelativeOrAbsolute);
            if (isUri)
            {
               Server.UriToRequest = urlTbx.Text;
               urlTbx.Enabled = false;
            }
            else
            {
               MessageBox.Show("Stop the Server and re-enter a valid URL.");
               closeServer();
            }
         }
         customMsgTbx.Enabled = true;
         startBtn.Enabled = false;
         stopBtn.Enabled = true;
         urlTbx.Enabled = false;
      }

      private void stopBtn_Click(object sender, EventArgs e)
      {
         closeServer();
      }

      private void closeServer()
      {
         if (newServer.IsListening)
         {
            newServer.Close();
            customMsgTbx.Enabled = false;
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            urlTbx.Enabled = true;
         }
      }

      private void customMsgTbx_MouseDown(object sender, MouseEventArgs e)
      {
         customMsgTbx.Text = "";
      }

      private void sendBtn_Click(object sender, EventArgs e)
      {
         Server.CustomMsgResponse(customMsgTbx.Text);
      }
   }
}
