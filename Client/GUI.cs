using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
   public partial class GUI : Form
   {
      public static string url;
      public static string api;

      public GUI()
      {
         InitializeComponent();
      }

      private void okKeyBtn_Click(object sender, EventArgs e)
      {
         apiKeyTbx.Enabled = false;
         okKeyBtn.Hide();
         api = apiKeyTbx.Text;
      }

      private async void addBtn_ClickAsync(object sender, EventArgs e)
      {
         try
         {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {{"username", usernameTbx.Text }, {"rank", rankTbx.Text }};

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://" + localhostTbx.Text + ":" + portTbx.Text + "/adduser.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseString);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }

      private void inventoryBtn_Click(object sender, EventArgs e)
      {
         Inventory inv = new Inventory();
         inv.Visible = true;
         url = "http://" + localhostTbx.Text + ":" + portTbx.Text;
         api = apiKeyTbx.Text;
      }
   }
}
