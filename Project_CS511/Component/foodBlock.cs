using MongoDB.Bson;
using Project_CS511.Properties;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component
{
    public partial class foodBlock : UserControl
    {
        mainForm main;
        BsonDocument foodBlockData;
        public string id;
        public string shopId;
        public double distance;
        public foodBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;         
        }


        public void addData(BsonDocument doc)
        {
            foodBlockData = doc;
            string path = getFoodPicturePath();
            shopId = doc["shopId"].AsString;
            id = doc["foodId"].AsString;

            //add image
            pb_picture.Image = Image.FromFile(path + doc["foodId"]+".png");

            //add food name
            lb_name.Text = doc["foodName"].AsString;

            //add money 
            lb_price.Text = FormatMoney(doc["price"].AsString) + "₫";

            //add shop name
            main.dataSource.SetCollection("user");
            lb_store.Text = main.dataSource.findValue("userId", shopId, "username");

            //add rating
            lb_star.Text = doc["rating"].AsString;

        }

        #region Các Hàm chức năng
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        public void setToAvoidConflict()
        {
            pb_picture.Image.Dispose();
            pb_picture.Image = Resources.add_food;
        }

        public void updateFoodBlock(string foodId)
        {
            main.dataSource.SetCollection("food");
            foodBlockData = main.dataSource.findOneDoc("foodId", foodId);
            main.dataSource.SetCollection("user");
        }

        public void updateStar(string foodId)
        {
            main.dataSource.SetCollection("food");
            lb_star.Text = main.dataSource.findValue("foodId", foodId, "rating");
            main.dataSource.SetCollection("user");
        }

        public void addDistance(string shopId)
        {
            main.dataSource.SetCollection("user");

            double shopLat = double.Parse(main.dataSource.findValue("userId",shopId, "coordinate").Split('-')[0]);
            double shopLong = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[1]);

            double distanceTemp = Math.Round(CalculateDistance(shopLat, shopLong, main.currentLatitude, main.currentLongitude),1);

            distance = distanceTemp;
            if(distance == 0)
            {
                lb_distance.Text = "";
            }
            else
            {
                lb_distance.Text = distance.ToString() + "Km";
            }
        }
        public double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {

            double radLat1 = ToRadians(lat1);
            double radLon1 = ToRadians(lon1);
            double radLat2 = ToRadians(lat2);
            double radLon2 = ToRadians(lon2);

            double deltaLat = radLat2 - radLat1;
            double deltaLon = radLon2 - radLon1;

            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) +
                       Math.Cos(radLat1) * Math.Cos(radLat2) *
                       Math.Pow(Math.Sin(deltaLon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = 6371 * c;

            return distance;
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }


        #endregion

        #region decoration
        private void pb_picture_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }

        private void pb_picture_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion

        private void pb_picture_Click(object sender, EventArgs e)
        {
            foodSubPage f = new foodSubPage(main);
            f.addDataFood(foodBlockData);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        


    }
}
