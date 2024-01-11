using MongoDB.Bson;
using Project_CS511.Properties;
using Project_CS511.SubPage;
using System;
using System.IO;
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
    public partial class restaurantBlock : UserControl
    {
        mainForm main;
        public string userId;
        public restaurantBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

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

        public void addData(BsonDocument doc)
        {
            main.dataSource.SetCollection("user");
            string path = getAvatarPath();
            userId = doc["userId"].AsString;

            //add avatar
            string avatarPath = getAvatarPath() + userId + ".png";
            if (File.Exists(avatarPath))
            {
                pb_picture.Image = Image.FromFile(avatarPath);
            }
            else
            {
                pb_picture.Image = Resources.customer_active;
            }

            //add food name
            lb_name.Text = doc["username"].AsString;
            addDistance(userId);
        }

        #region cac ham chuc nang
        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;

        }
        #endregion

        private void pb_picture_Click(object sender, EventArgs e)
        {
            shop f = new shop(main, userId);
            main.Controls.Add(f);
            main.bringControlToFront(f);

        }

        public void setImageToDefault()
        {
            pb_picture.Image.Dispose();
            pb_picture.Image = Resources._default;
        }


        private void restaurantBlock_Load(object sender, EventArgs e)
        {

        }

        public void addDistance(string shopId)
        {
            main.dataSource.SetCollection("user");

            double shopLat = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[0]);
            double shopLong = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[1]);

            double distance = Math.Round(CalculateDistance(shopLat, shopLong, main.currentLatitude, main.currentLongitude), 1);

            lb_distance.Text = distance.ToString() + "Km";
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
    }
}
