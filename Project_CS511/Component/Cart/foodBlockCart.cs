using Project_CS511.Pages;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component.Cart
{
    public partial class foodBlockCart : UserControl
    {
        mainForm main;
        public int money;
        int thisprice;
        public foodBlockCart(mainForm main, string id, string name, string price)
        {
            InitializeComponent();
            Name = id;
            this.main = main;
            pb_foodPic.Image = Image.FromFile(getFoodPicturePath()+id+".png");
            lb_foodName.Text = name;
            thisprice = Int32.Parse(price);
            string tempMoney = (Int32.Parse(price) * Int32.Parse(lb_number.Text)).ToString();
            lb_money.Text = FormatMoney(tempMoney) + "₫";
            money = Convert.ToInt32(tempMoney);
        }

        #region Cac ham chuc nang
        public void updateQuantity()
        {
            lb_number.Text = (Int32.Parse(lb_number.Text) + 1).ToString();
            string tempMoney = (Int32.Parse(lb_money.Text.Replace("₫", "").Replace(",", "")) + thisprice).ToString();
            lb_money.Text = FormatMoney(tempMoney) + "₫";
            money = Convert.ToInt32(tempMoney);
        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        private void addToCart(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "cart").Split('-').ToList();

            if (likedProduct[0] == "")
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", foodId);
            }
            else
            {
                string newLiked = main.dataSource.findValue("loginName", main.currentUser, "cart") + "-" + foodId;
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", newLiked);
            }
        }

        private void removeFromCart(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "cart").Split('-').ToList();

            if (likedProduct.Count == 1)
            {
                if (likedProduct.Contains(foodId))
                {
                    main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", "");
                }
            }
            else
            {
                likedProduct.Remove(foodId);
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", string.Join("-", likedProduct));
            }
        }

        #endregion
        private void pb_add_Click(object sender, EventArgs e)
        {
            string tempMoney = ((Int32.Parse(lb_money.Text.Replace("₫", "").Replace(",", "")) / ( Int32.Parse(lb_number.Text)) * (Int32.Parse(lb_number.Text) + 1))).ToString();

            lb_number.Text = (Int32.Parse(lb_number.Text) + 1).ToString();
            lb_money.Text = FormatMoney(tempMoney) + "₫";
            addToCart(Name);

            money = Convert.ToInt32(tempMoney);
            cartSubPage cartPage = (cartSubPage)main.Controls.Find("cartSubPage", true).FirstOrDefault();
            cartPage.totalMoney();
        }

        private void pb_sub_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(lb_number.Text) - 1 == 0)
            {
                removeFromCart(Name);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                string tempMoney = ((Int32.Parse(lb_money.Text.Replace("₫", "").Replace(",", "")) / (Int32.Parse(lb_number.Text)) * (Int32.Parse(lb_number.Text) - 1))).ToString();

                lb_number.Text = (Int32.Parse(lb_number.Text) - 1).ToString();
                lb_money.Text = FormatMoney(tempMoney) + "₫";
                money = Convert.ToInt32(tempMoney);
                removeFromCart(Name);

            }

            cartSubPage cartPage = (cartSubPage)main.Controls.Find("cartSubPage", true).FirstOrDefault();
            cartPage.totalMoney();
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "cart").Split('-').ToList();

            if (likedProduct.Count == 1)
            {
                if (likedProduct.Contains(Name))
                {
                    main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", "");
                }
            }
            else
            {
                likedProduct.RemoveAll(x => x == Name);
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", string.Join("-", likedProduct));
            }

            this.Parent.Controls.Remove(this);

            cartSubPage cartPage = (cartSubPage)main.Controls.Find("cartSubPage", true).FirstOrDefault();
            cartPage.totalMoney();
        }
    }
}
