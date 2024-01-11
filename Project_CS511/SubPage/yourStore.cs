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
using MongoDB.Bson;
using Project_CS511.Component.yourStore;
using Project_CS511.Component.shopSubPage;
using Project_CS511.Component;
using DnsClient;
using Project_CS511.Pages;

namespace Project_CS511.SubPage
{
    public partial class yourStore : UserControl
    {
        mainForm main;
        string newImageFoodPath = "";
        public yourStore(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init(main.currentId);
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


            //add filter to combobox 2
            cb_foodType.Items.Add("Drink");
            cb_foodType.Items.Add("Fast Food");
            cb_foodType.Items.Add("Cake");
            cb_foodType.Items.Add("Vegan");
            cb_foodType.Items.Add("Sushi");

            addData(userId);
        }

        private void addData(string userId)
        {
            main.dataSource.SetCollection("food");
            List<BsonDocument> foodOfShop = main.dataSource.findMultipleDoc("shopId", userId);
            foreach (BsonDocument food in foodOfShop)
            {
                yourStoreBlock temp = new yourStoreBlock(main);
                temp.addData(food["foodId"].AsString);
                flowLayoutPanel1.Controls.Add(temp);
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

        #region search function
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                yourStoreBlock storeBlock = (yourStoreBlock)c;
                if (storeBlock.isSearched == true)
                {
                    if (tb_search.Text == "" || storeBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                    {
                        storeBlock.Visible = true;
                    }
                    else if (!storeBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                    {
                        storeBlock.Visible = false;
                    }
                }
            }
        }

        private void cb_filter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_filter.SelectedIndex != -1)
            {
                string selectedItem = cb_filter.SelectedItem.ToString();
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    yourStoreBlock storeBlock = (yourStoreBlock)c;
                    if (storeBlock.thisfoodType == selectedItem)
                    {
                        storeBlock.isSearched = true;
                        if (tb_search.Text == "" || storeBlock.getName().ToLower().Contains(tb_search.Text.ToLower()))
                        {
                            storeBlock.Visible = true;
                        }
                        else
                        {
                            storeBlock.Visible = false;
                        }
                    }
                    else
                    {
                        storeBlock.isSearched = false;
                        storeBlock.Visible = false;
                    }
                }
            }
        }

        private string getFoodPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        public void notification()
        {
            btn_success.Visible = true;
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 2000,
                Enabled = true
            };

            timer.Elapsed += (timerSender, timerEvent) =>
            {
                btn_success.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        #endregion

        private void btn_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("yourStore");
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            if (tb_search.Text == "What shall we deliver?")
                tb_search.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pb_newImg.Image.Dispose();
                pb_newImg.Image = Image.FromFile(selectedFilePath);
                newImageFoodPath = selectedFilePath;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(tb_name.Text != "" && tb_price.Text!= "" && cb_foodType.Text != "")
            {
                main.dataSource.SetCollection("genericInfo");
                int newMaxId = Int32.Parse(main.dataSource.findValue("id", "1", "maxFoodId"))+1;
                main.dataSource.findAndReplaceOne("id", "1", "maxFoodId", newMaxId.ToString());
                main.dataSource.SetCollection("food");

                string destinationFolder = Path.Combine(getFoodPath(), newMaxId + ".png");
                if (newImageFoodPath != "")
                {
                    File.Copy(newImageFoodPath, destinationFolder, true);
                }
                else
                {
                    File.Copy(getFoodPath() + "default.png", destinationFolder, true);
                }    

                BsonDocument newComment = new BsonDocument
                {
                {"foodId", newMaxId.ToString()},
                {"shopId", main.currentId},
                {"foodName", tb_name.Text},
                {"foodType", cb_foodType.Text },
                {"price", tb_price.Text },
                {"comment", "" },
                {"rating", "No Rating" },
                };
                main.dataSource.insertToCollection(newComment);
                addNotify("add", tb_name.Text);

                //set iamge to avoid conflict
                pb_newImg.Image.Dispose();
                pb_newImg.Image = Resources.add_food;

                main.dataSource.SetCollection("user");
                //notification();


                //add new food
                yourStoreBlock temp = new yourStoreBlock(main);
                temp.addData(newMaxId.ToString());
                flowLayoutPanel1.Controls.Add(temp);
            }
        }

        private void addNotify(string action, string foodName)
        {
            main.dataSource.SetCollection("user");
            chatBlock f = new chatBlock(main);
            if (action == "add")
            {
                f.addNotify(foodName);
            }
            else
            {
                f.deletedNotify(foodName);
            }

            main.messagePage.init();
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
