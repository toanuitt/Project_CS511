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
            return totalShopBill;
        }
    }
}
