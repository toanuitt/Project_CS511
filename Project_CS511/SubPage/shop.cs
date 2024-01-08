using MongoDB.Bson;
using Project_CS511.Component.shopSubPage;
using Project_CS511.Pages;
using Project_CS511.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_CS511.SubPage
{
    public partial class shop : UserControl
    {
        mainForm main;
        public shop(mainForm main, string userId)
        {
            InitializeComponent();
            this.main = main;
            init(userId);
        }

        private void init(string userId)
        {
            main.dataSource.SetCollection("user");
            //add name
            lb_name.Text = main.dataSource.findValue("userId", userId, "username");
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
            //add phone
            lb_phone.Text = "Phone: " + main.dataSource.findValue("userId", userId, "sdt");
            //add address
            lb_address.Text = main.dataSource.findValue("userId", userId, "location");

            //add filter to combobox
            cb_filter.Items.Add("Drink");
            cb_filter.Items.Add("Fast Food");
            cb_filter.Items.Add("Cake");
            cb_filter.Items.Add("Vegan");
            cb_filter.Items.Add("Sushi");

            addData(userId);
        }


        private void addData(string userId)
        {
            main.dataSource.SetCollection("food");
            List<BsonDocument> foodOfShop = main.dataSource.findMultipleDoc("shopId", userId);
            foreach(BsonDocument food in foodOfShop)
            {
                shopFoodBlock shopFoodBlock = new shopFoodBlock(main);
                shopFoodBlock.addData(food["foodId"].AsString);
                flowLayoutPanel1.Controls.Add(shopFoodBlock);
            }

            main.dataSource.SetCollection("user");
        }
        #region cac ham chuc nang
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;

        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }
        #endregion

        private void btn_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("shop");
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            if(tb_search.Text  == "What shall we deliver?")
                tb_search.Text = "";
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                shopFoodBlock foodBlock = (shopFoodBlock)c;
                if (foodBlock.isSearched == true)
                {
                    if (tb_search.Text == "" || foodBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                    {
                        foodBlock.Visible = true;
                    }
                    else if (!foodBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                    {
                        foodBlock.Visible = false;
                    }
                }
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filter.SelectedIndex != -1)
            {
                string selectedItem = cb_filter.SelectedItem.ToString();
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    shopFoodBlock foodBlock = (shopFoodBlock)c;
                    if(foodBlock.thisfoodType == selectedItem)
                    {
                        foodBlock.isSearched = true;
                        if (tb_search.Text == "" || foodBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                        {
                            foodBlock.Visible = true;
                        }
                        else
                        {
                            foodBlock.Visible = false;
                        }    
                    }
                    else
                    {
                        foodBlock.isSearched = false;
                        foodBlock.Visible = false;
                    }
                }
            }
        }
    }
}
