using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
   public partial class Inventory : Form
   {
      public Inventory()
      {
         InitializeComponent();

         SQLiteDataReader reader = PopulateListView();
         while (reader.Read())
         {
            ListViewItem lvi = new ListViewItem(reader["id"].ToString());
            lvi.SubItems.Add(reader["product"].ToString());
            lvi.SubItems.Add(reader["custName"].ToString());
            lvi.SubItems.Add(reader["price"].ToString());
            lvi.SubItems.Add(reader["date"].ToString());
            inventoryLstvw.Items.Add(lvi);
         }
         reader.Close();
      }



      private SQLiteDataReader PopulateListView()
      {
         SQLiteDataReader reader;
         System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=db.sqlite3");
         SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con);
         con.Open();
         com.CommandText = "Select * FROM inventory_";
         reader = com.ExecuteReader();
         return reader;
      }

      private void AddRecord()
      {
         string tableQuery = @"CREATE TABLE IF NOT EXISTS [MyTable] ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[Key] NVARCHAR(2048)  NULL,[Value] VARCHAR(2048)  NULL)";
         using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=db.sqlite3"))
         {
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
            {
               con.Open();

               com.CommandText = tableQuery;
               com.ExecuteNonQuery();
               con.Close();
            }
         }

      }

      private  async void addorderBtn_Click(object sender, EventArgs e)
      {
         try
         {
             HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
               {"apikey", GUI.api},
               {"product", productTbx.Text}, {"custName", customerTbx.Text},
               {"price", pricetbx.Text}, {"date", datetbx.Text}
            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync((GUI.url+ "/inventory.php"), content);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseString);
            client.Dispose();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }
   }
}
