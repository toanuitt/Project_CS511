using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component.Cart
{
    public partial class OrderBlock : UserControl
    {
        mainForm main;
        public List<string> items  = new List<string>();
        public int shopOrderMoney = 0;
        public int shippingFee = 0;
        public OrderBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        public void addData(string name, string Newid)
        {
            lb_shopName.Text = name;
            Name = Newid;
        }
        public void addFoodBlock(BsonDocument data)
        {
            items.Add(data["foodId"].AsString);
            foodBlockCart f = new foodBlockCart(main, data["foodId"].AsString, data["foodName"].AsString, data["price"].AsString);
            flp_order.Controls.Add(f);
        }

        public void updatefoodBlock(string id)
        {
            foodBlockCart founded = (foodBlockCart)flp_order.Controls.Find(id, true).FirstOrDefault();
            founded.updateQuantity();
        }

        public int getShopBill()
        {
            int totalShopBill = 0;
            foreach (Control c in flp_order.Controls)
            {
                foodBlockCart foodBlockCart = (foodBlockCart)c;
                totalShopBill += foodBlockCart.money;
            }
            shopOrderMoney = totalShopBill;
            return totalShopBill;
        }

        public void addShipFee()
        {
            foodBlockCart example = (foodBlockCart)flp_order.Controls[0];
            double distance = addDistance(example.shopId);
            int fee = 15000 + 5000*(int)(distance / 3);
            shippingFee = fee;
            lb_shipping.Text = FormatMoney(fee.ToString()).ToString();
        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        public int getControlNum()
        {
            return flp_order.Controls.Count;
        }

        public double addDistance(string shopId)
        {
            main.dataSource.SetCollection("user");

            double shopLat = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[0]);
            double shopLong = double.Parse(main.dataSource.findValue("userId", shopId, "coordinate").Split('-')[1]);

            double distance = Math.Round(CalculateDistance(shopLat, shopLong, main.currentLatitude, main.currentLongitude), 1);

            return distance;
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
