using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Component.Cart;
using Project_CS511.Properties;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_CS511.Component.yourStore
{
    public partial class yourStoreBlock : UserControl
    {
        mainForm main;
        string thisfoodId;
        public string thisfoodType;
        public bool isSearched = true;

        public yourStoreBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            cb_foodType.Items.Add("Drink");
            cb_foodType.Items.Add("Fast Food");
            cb_foodType.Items.Add("Cake");
            cb_foodType.Items.Add("Vegan");
            cb_foodType.Items.Add("Sushi");
        }

        public void addData(string foodId)
        {
            thisfoodId = foodId;

            main.dataSource.SetCollection("food");
            thisfoodType = main.dataSource.findValue("foodId", foodId, "foodType");

            //add name
            tb_name.Text = main.dataSource.findValue("foodId", foodId, "foodName");
            //add picture
            pb_picture.Image = Image.FromFile(getFoodPicturePath() + foodId + ".png");
            //add price
            tb_price.Text = main.dataSource.findValue("foodId", foodId, "price").ToString();

            //add combobox
            if(thisfoodType == "fastfood")
            {
                cb_foodType.SelectedIndex = cb_foodType.Items.IndexOf("Fast Food");
            }
            else
            {
                int index = cb_foodType.Items.IndexOf(CapitalizeFirstLetter(thisfoodType));
                cb_foodType.SelectedIndex = index;
            }
        }

        #region cac ham chuc nang
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public string getName()
        {
            main.dataSource.SetCollection("food");
            string name = main.dataSource.findValue("foodId", thisfoodId, "foodName");
            main.dataSource.SetCollection("user");
            return name;
        }

        #endregion

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(btn_update.Text == "Confirm")
            {
                main.dataSource.SetCollection("food");
                main.dataSource.findAndReplaceOne("foodId", thisfoodId, "foodName", tb_name.Text);
                main.dataSource.findAndReplaceOne("foodId", thisfoodId, "price", tb_price.Text);
                main.dataSource.findAndReplaceOne("foodId", thisfoodId, "foodType", cb_foodType.Text.ToLower().Replace(" ",""));
                main.dataSource.SetCollection("user");
                updateToggle("off");
            }
            else
            {
                updateToggle("on");            
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (btn_delete.Text == "Cancel")
            {
                updateToggle("off");
            }
            else
            {
                main.dataSource.SetCollection("food");
                string notify = "Delete " + main.dataSource.findValue("foodId", thisfoodId, "foodName");
                DialogResult result = MessageBox.Show(notify, "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    addNotify("delete", main.dataSource.findValue("foodId", thisfoodId, "foodName"));
                    main.dataSource.SetCollection("food");
                    main.dataSource.deleteOneByValue("foodId", thisfoodId);
                    removeFromCart(thisfoodId);
                    removeFromLiked(thisfoodId);
                    removeComment(thisfoodId);
                    removeBoughtProduct(thisfoodId);
                    pb_picture.Image.Dispose();
                    pb_picture.Image = Resources.add_food;
                    this.Parent.Controls.Remove(this);
                    main.dataSource.SetCollection("user");
                }
                main.messagePage.setToAvoidConflict();
                main.homePage.setToAvoidConflictFood();
                main.foodPage.setToAvoidConflict();
                File.Delete(getFoodPicturePath() + thisfoodId + ".png");
                main.homePage.updateFoodAfterDelete();
                main.messagePage.init();
;            }
        }

        #region cac ham chuc nang
        private void removeFromCart(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<BsonDocument> allUsers = main.dataSource.returnAllData();
            foreach(BsonDocument user in allUsers)
            {
                List<string> likedProduct = main.dataSource.findValue("userId", user["userId"].AsString, "cart").Split('-').ToList();
                if(likedProduct.Contains(foodId))
                {
                    if (likedProduct.Count == 1)
                    {
                        main.dataSource.findAndReplaceOne("userId", user["userId"].AsString, "cart", "");
                    }
                    else
                    {
                        likedProduct.Remove(foodId);
                        main.dataSource.findAndReplaceMany("userId", user["userId"].AsString, "cart", string.Join("-", likedProduct));
                    }
                }        
            }          
        }

        private void removeFromLiked(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<BsonDocument> allUsers = main.dataSource.returnAllData();
            foreach (BsonDocument user in allUsers)
            {
                List<string> likedProduct = main.dataSource.findValue("userId", user["userId"].AsString, "liked").Split('-').ToList();
                if (likedProduct.Contains(foodId))
                {
                    if (likedProduct.Count == 1)
                    {
                        main.dataSource.findAndReplaceOne("userId", user["userId"].AsString, "liked", "");
                    }
                    else
                    {
                        likedProduct.Remove(foodId);
                        main.dataSource.findAndReplaceMany("userId", user["userId"].AsString, "liked", string.Join("-", likedProduct));
                    }
                }
            } 
        }

        private void removeComment(string foodId)
        {
            main.dataSource.SetCollection("foodComment");

            main.dataSource.deleteManyByValue("foodId", foodId);

            main.dataSource.SetCollection("user");
        }

        private void removeBoughtProduct(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<BsonDocument> allUsers = main.dataSource.returnAllData();
            foreach (BsonDocument user in allUsers)
            {
                List<string> likedProduct = main.dataSource.findValue("userId", user["userId"].AsString, "boughtFood").Split('-').ToList();
                if (likedProduct.Contains(foodId))
                {
                    if (likedProduct.Count == 1)
                    {
                        main.dataSource.findAndReplaceOne("userId", user["userId"].AsString, "boughtFood", "");
                    }
                    else
                    {
                        likedProduct.Remove(foodId);
                        main.dataSource.findAndReplaceMany("userId", user["userId"].AsString, "boughtFood", string.Join("-", likedProduct));
                    }
                }
            }
        }

        private void updateToggle(string state)
        {
            if(state == "on")
            {
                btn_update.BackColor = Color.LightGreen;
                btn_update.Text = "Confirm";
                btn_delete.Text = "Cancel";
                tb_name.ReadOnly = false;
                tb_price.ReadOnly = false;
                cb_foodType.Enabled = true;
            }
            if (state == "off")
            {
                btn_update.BackColor = Color.LightBlue;
                btn_update.Text = "Update";
                btn_delete.Text = "Delete";
                tb_name.ReadOnly = true;
                tb_price.ReadOnly = true;
                cb_foodType.Enabled = false;
            }

        }

        private void addNotify(string action,string foodName)
        {
            main.dataSource.SetCollection("user");
            chatBlock f = new chatBlock(main);
            if(action == "add")
            {
                f.addNotify(foodName);
            }
            else
            {
                f.deletedNotify(foodName);
            }

            main.messagePage.init();
        }


        private string getFoodPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        #endregion

        private void pb_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string destinationFolder = Path.Combine(getFoodPath(), thisfoodId + ".png");

                try
                {
                    pb_picture.Image.Dispose();
                    main.homePage.setToAvoidConflictFood();
                    main.foodPage.setToAvoidConflict();

                    File.Copy(selectedFilePath, destinationFolder, true);
                    pb_picture.Image = Image.FromFile(getFoodPath() + thisfoodId + ".png");
                    main.homePage.updateFoodAfterDelete();

                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
