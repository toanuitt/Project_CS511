using MongoDB.Bson;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_CS511.Component
{
    public partial class foodlist : UserControl
    {
        mainForm main;
        public foodlist(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        #region getset
        private string _pic;
        private string _name;
        private string _price;
        private string _foodid;
        private string _shopid;
        private string _rating;

        [Category("Custom Props")]
        public string Picture
        {
            get { return _pic; }
            set
            {
                _pic = value;
                string path = getFoodPicturePath();
                pb_picture.Image = Image.FromFile(path + _pic + ".png");
            }
        }
        [Category("Custom Props")]
        public string Namefood
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = _name; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = _price + " đ"; }
        }
        [Category("Custom Props")]
        public string FoodID
        {
            get { return _foodid; }
            set { _foodid = value; }
        }
        [Category("Custom Props")]
        public string ShopID
        {
            get { return _shopid; }
            set { _shopid = value; }
        }
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; lb_star.Text = _rating; }
        }



        #endregion
        #region Các Hàm chức năng
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        public void disposeImg()
        {
            pb_picture.Image.Dispose();
        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        public void addDistance(string shopId)
        {
            main.dataSource.SetCollection("user");

            double shopLat = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[0]);
            double shopLong = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[1]);

            double distance = Math.Round(CalculateDistance(shopLat, shopLong, main.currentLatitude, main.currentLongitude), 1);

            if (distance == 0)
            {
                lb_distance.Text = "";
            }
            else
            {
                lb_distance.Text = distance.ToString() + "Km";
            }
        }
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
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

        private void pb_picture_Click(object sender, EventArgs e)
        {
            foodSubPage f = new foodSubPage(main);
            f.addDataFoodpage(_shopid,_pic, _name, _price, _rating);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }
    }
}
