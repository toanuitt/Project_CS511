using Project_CS511.Pages;
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

namespace Project_CS511.Component.shopSubPage
{
    public partial class shopFoodBlock : UserControl
    {
        mainForm main;
        string thisfoodId;
        public string thisfoodType;
        bool liked = false;
        public bool isSearched = true;

        public shopFoodBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void addData(string foodId)
        {
            thisfoodId = foodId;

            main.dataSource.SetCollection("food");
            thisfoodType = main.dataSource.findValue("foodId", foodId, "foodType");

            //add name
            lb_name.Text = main.dataSource.findValue("foodId", foodId, "foodName");
            //add picture
            pb_picture.Image = Image.FromFile(getFoodPicturePath() + foodId + ".png");
            //add price
            lb_price.Text =  FormatMoney(main.dataSource.findValue("foodId", foodId, "price").ToString()) + "₫";

            string userId = main.dataSource.findValue("foodId", foodId, "shopId");
            main.dataSource.SetCollection("user");
            lb_store.Text = main.dataSource.findValue("loginName", main.currentUser, "username");

            //add heart
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();
            if (likedProduct.Contains(foodId))
            {
                pb_like.Image = Resources.heart_on;
                liked = true;
            }
        }

        #region cac ham chuc nang
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

        private void addToLiked(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();

            if (likedProduct[0] == "")
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "liked", foodId);
            }
            else
            {
                string newLiked = main.dataSource.findValue("loginName", main.currentUser, "liked") + "-" + foodId;
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "liked", newLiked);
            }
        }

        public string getName()
        {
            main.dataSource.SetCollection("food");
            string name = main.dataSource.findValue("foodId", thisfoodId, "foodName");
            main.dataSource.SetCollection("user");
            return name;
        }

        private void removeFromLiked(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();

            if (likedProduct.Count == 1)
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "liked", "");
            }
            else
            {
                likedProduct.Remove(foodId);
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "liked", string.Join("-", likedProduct));
            }
        }

        #endregion


        private void pb_like_Click_1(object sender, EventArgs e)
        {
            if (liked)
            {
                pb_like.Image = Resources.heart_off;
                removeFromLiked(thisfoodId);
                liked = false;
            }
            else
            {
                pb_like.Image = Resources.heart_on;
                addToLiked(thisfoodId);
                liked = true;
            }
        }

        private void lb_name_Click(object sender, EventArgs e)
        {
            //main.RemoveControlByName("shop");

            main.dataSource.SetCollection("food");
            foodSubPage f = new foodSubPage(main);
            f.addDataFood(main.dataSource.findOneDoc("foodId", thisfoodId));
            main.Controls.Add(f);
            main.bringControlToFront(f);
            main.dataSource.SetCollection("user");
        }

        private void shopFoodBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
