using Amazon.Runtime.Documents;
using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Component;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.SubPage
{
    public partial class map : UserControl
    {
        mainForm main;
        public map(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        // allow user to open map to choose location
        public void btn_mapchoose_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.maplocationPage.Show();
            main.maplocationPage.Init();
            main.maplocationPage.getPage(number);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.ShowMenu();
            main.foodPage.Show();
        }
        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.mapPage != null) { main.mapPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        private int number = 1;
        private void btn_recent_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            number = 1;
            btn_recent.BackColor = Color.LightCyan;
            btn_recent.ForeColor = Color.Green;
            btn_saved.BackColor = Color.White;
            btn_saved.ForeColor = Color.Gray;
            Init();
            // add database recent to flowlayoutpanel1
        }

        private void btn_saved_Click(object sender, EventArgs e)
        {
            number = 2;
            btn_saved.BackColor = Color.LightCyan;
            btn_saved.ForeColor = Color.Green;
            btn_recent.BackColor = Color.White;
            btn_recent.ForeColor = Color.Gray;
            flowLayoutPanel1.Controls.Clear();
            var addlocation = new addLocation(main);
            flowLayoutPanel1.Controls.Add(addlocation);
            
            // add database saved to flowlayoutpanel1
        }
        public void getAddress(string address)
        {
            txtbox_address.Text = address;
        }
        private void map_Load(object sender, EventArgs e)
        {
         
          
        }
        // setting the flowlayoutpanel to show the history
        public void Init()
        {
            btn_saved.Visible = true;
            btn_recent.Visible = true;
            var newlocation = new location(main);
            flowLayoutPanel1.Controls.Clear();
            main.dataSource.SetCollection("user");
            string userlocation = main.dataSource.findValue("loginName", main.currentUser, "location");
            newlocation.passaddress(userlocation);
            flowLayoutPanel1.Controls.Add(newlocation);
            IMongoCollection<BsonDocument> collections = main.dataSource.data.GetCollection<BsonDocument>("location");
            var filter = Builders<BsonDocument>.Filter.Eq("userid", main.currentUser);
            var result = collections.Find(filter).ToList();

            // Reverse the order of documents for bottom-up display
            int displayCount = Math.Min(result.Count, 5);

            // Reverse the order of documents for bottom-up display
            for (int i = displayCount - 1; i >= 0; i--)
            {
                var document = result[i];
                var location = document.GetValue("location").AsString;
                var newestlocation = new location(main);
                newestlocation.passhistoryaddress(location);
                flowLayoutPanel1.Controls.Add(newestlocation);
            }
        }

        private void txtbox_address_TextChanged(object sender, EventArgs e)
        {
            btn_saved.Visible = false;
            btn_recent.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            
            IMongoCollection<BsonDocument> collections = main.dataSource.data.GetCollection<BsonDocument>("address");
            if (txtbox_address.Text != "")
            {
                var filter = Builders<BsonDocument>.Filter.Regex("address", new BsonRegularExpression(txtbox_address.Text, "i"));
                var matchingDocuments = collections.Find(filter).ToList();
                foreach (var document in matchingDocuments)
                {
                    if (document.Contains("address"))
                    {
                        var addressValue = document["address"].AsString;
                        var newestlocation = new location(main);
                        newestlocation.passrecommendaddress(addressValue);
                        flowLayoutPanel1.Controls.Add(newestlocation);

                    }
                }
            }
            else
            {
                var allDocuments = collections.Find(Builders<BsonDocument>.Filter.Empty).ToList();
                foreach (var document in allDocuments)
                {
                    if (document.Contains("address"))
                    {
                        var addressValue = document["address"].AsString;
                        var newestlocation = new location(main);
                        newestlocation.passrecommendaddress(addressValue);
                        flowLayoutPanel1.Controls.Add(newestlocation);

                    }
                }
            }

        }
    }
}
