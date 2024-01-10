﻿using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Component;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Pages
{
    public partial class food : UserControl
    {
        mainForm main;
        public food(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            // init current user
            currentuser = new Addressuser();
            Allvalue();
        }

        private void food_Load(object sender, EventArgs e)
        {

        }
        // move to map.cs
        private void lbl_address_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.mapPage.getAddress(userlocation);
            main.mapPage.Init();
            main.mapPage.Show();
        }

        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.foodPage != null) { main.foodPage.Hide(); }
            main.HideMenu();
            //if ( != null) { main.foodPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        public class Addressuser
        {
            public string Address { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        public Addressuser currentuser;

        //set label address
        public void SetLabelAddress(string address)
        {
            lbl_address.Text = address;
        }

        public string GetLabelAddress()
        {
            return lbl_address.Text;
        }
        #region calculate time and distance
        public (string Time, string Distance) getDistance(string origin, string destination)
        {
            string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + origin + "&destinations=" + destination + "&key=" + main.api_key;
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    string time = dsResult.Tables["duration"].Rows[0]["text"].ToString();
                    string distance = dsResult.Tables["distance"].Rows[0]["text"].ToString();
                    return (time, distance);
                }
            }

        }
        #endregion

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            btn_delivery.BackColor = Color.LightCyan;
            btn_delivery.ForeColor = Color.Teal;
            btn_dinner.BackColor = SystemColors.Control;
            btn_dinner.ForeColor = SystemColors.ControlText;

        }

        private void btn_dinner_Click(object sender, EventArgs e)
        {
            btn_dinner.BackColor = Color.LightCyan;
            btn_dinner.ForeColor = Color.Teal;
            btn_delivery.BackColor = SystemColors.Control;
            btn_delivery.ForeColor = SystemColors.ControlText;
        }
        public string userlocation;
        public void Init()
        {
            main.dataSource.SetCollection("user");
            userlocation = main.dataSource.findValue("loginName", main.currentUser, "location");
            if (userlocation != "")
                lbl_address.Text = userlocation.Substring(0, 12) + "...";
            else
                lbl_address.Text = "Please update your location";

        }
        public void Allvalue()
        {
            IMongoCollection<BsonDocument> collections = main.dataSource.data.GetCollection<BsonDocument>("food");
            var filter = Builders<BsonDocument>.Filter.Empty; // Empty filter to get all documents
            var result = collections.Find(filter).ToList();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                var document = result[i];
                var foodmenu = new foodlist(main);
                foodmenu.Picture = document.GetValue("foodId").AsString;
                foodmenu.Namefood = document.GetValue("foodName").AsString;
                foodmenu.Price = document.GetValue("price").AsString;
                flowLayoutPanel1.Controls.Add(foodmenu);
            }
        }
        private int clickCounterdrink = 0;
        private void pic_drink_Click(object sender, EventArgs e)
        {
            clickCounterdrink++;
            switch (clickCounterdrink % 2)
            {
                case 1:
                    pic_drink.Image = Properties.Resources.drink_check;
                    addData();
                    break;
                case 0:
                    pic_drink.Image = Properties.Resources.drink;
                    addData();
                    break;
            }
        }
        private int clickCounterfastfood = 0;
        private void pic_fastfood_Click(object sender, EventArgs e)
        {
            clickCounterfastfood++;
            switch (clickCounterfastfood % 2)
            {
                case 1:
                    pic_fastfood.Image = Properties.Resources.burger_check;
                    addData();
                    break;
                case 0:
                    pic_fastfood.Image = Properties.Resources.burger;
                    addData();
                    break;
            }
        }
        private int clickCountercake = 0;
        private void pic_cake_Click(object sender, EventArgs e)
        {
            clickCountercake++;
            switch (clickCountercake % 2)
            {
                case 1:
                    pic_cake.Image = Properties.Resources.cake_check;
                    addData();
                    break;
                case 0:
                    pic_cake.Image = Properties.Resources.cake;
                    addData();
                    break;
            }
        }
        private int clickCountervegan = 0;
        private void pic_vegan_Click(object sender, EventArgs e)
        {
            clickCountervegan++;
            switch (clickCountervegan % 2)
            {
                case 1:
                    pic_vegan.Image = Properties.Resources.coconut_check;
                    addData();
                    break;
                case 0:
                    pic_vegan.Image = Properties.Resources.coconut;
                    addData();
                    break;
            }
        }
        private int clickCountersushi = 0;
        private void pic_sushi_Click(object sender, EventArgs e)
        {
            clickCountersushi++;
            switch (clickCountersushi % 2)
            {
                case 1:
                    pic_sushi.Image = Properties.Resources.sushi_check;
                    addData();
                    break;
                case 0:
                    pic_sushi.Image = Properties.Resources.sushi;
                    addData();
                    break;
            }
        }
        private void addData()
        {
            flowLayoutPanel1.Controls.Clear();
            IMongoCollection<BsonDocument> collections = main.dataSource.data.GetCollection<BsonDocument>("food");
            if (clickCounterdrink % 2 == 1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("foodType", "Drink");
                var result = collections.Find(filter).ToList();
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    var document = result[i];
                    var foodmenu = new foodlist(main);
                    foodmenu.Picture = document.GetValue("foodId").AsString;
                    foodmenu.Namefood = document.GetValue("foodName").AsString;
                    foodmenu.Price = document.GetValue("price").AsString;
                    flowLayoutPanel1.Controls.Add(foodmenu);
                }
            }
            if (clickCounterfastfood % 2 == 1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("foodType", "Fast Food");
                var result = collections.Find(filter).ToList();
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    var document = result[i];
                    var foodmenu = new foodlist(main);
                    foodmenu.Picture = document.GetValue("foodId").AsString;
                    foodmenu.Namefood = document.GetValue("foodName").AsString;
                    foodmenu.Price = document.GetValue("price").AsString;
                    flowLayoutPanel1.Controls.Add(foodmenu);
                }
            }
            if (clickCountercake % 2 == 1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("foodType", "Cake");
                var result = collections.Find(filter).ToList();
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    var document = result[i];
                    var foodmenu = new foodlist(main);
                    foodmenu.Picture = document.GetValue("foodId").AsString;
                    foodmenu.Namefood = document.GetValue("foodName").AsString;
                    foodmenu.Price = document.GetValue("price").AsString;
                    flowLayoutPanel1.Controls.Add(foodmenu);
                }
            }
            if (clickCountervegan % 2 == 1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("foodType", "Vegan");
                var result = collections.Find(filter).ToList();
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    var document = result[i];
                    var foodmenu = new foodlist(main);
                    foodmenu.Picture = document.GetValue("foodId").AsString;
                    foodmenu.Namefood = document.GetValue("foodName").AsString;
                    foodmenu.Price = document.GetValue("price").AsString;
                    flowLayoutPanel1.Controls.Add(foodmenu);
                }
            }
            if (clickCountersushi % 2 == 1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("foodType", "Sushi");
                var result = collections.Find(filter).ToList();
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    var document = result[i];
                    var foodmenu = new foodlist(main);
                    foodmenu.Picture = document.GetValue("foodId").AsString;
                    foodmenu.Namefood = document.GetValue("foodName").AsString;
                    foodmenu.Price = document.GetValue("price").AsString;
                    flowLayoutPanel1.Controls.Add(foodmenu);
                }
            }

        }
    }
}
