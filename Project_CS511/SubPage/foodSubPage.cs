using MongoDB.Bson;
using Project_CS511.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.SubPage
{
    public partial class foodSubPage : UserControl
    {
        mainForm main;
        string foodId;
        public foodSubPage(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            for(int i = 0; i < 10; i++)
            {
                foodCommentBubble b = new foodCommentBubble();
                flowLayoutPanel1.Controls.Add(b);
            }    
        }

        public void addDataFood(BsonDocument dataFood)
        {
            string path = getFoodPicturePath();
            string shopId = dataFood["shopId"].AsString;

            foodId = dataFood["foodId"].ToString();

            //add image
            pb_food.Image = Image.FromFile(path+ dataFood["foodId"] + ".png");

            //add food name
            lb_name.Text = dataFood["foodName"].AsString;

            //add money 
            lb_price.Text = FormatMoney(dataFood["price"].AsString) + "₫";

            //add shop name
            main.dataSource.SetCollection("user");
            lb_store.Text = main.dataSource.findValue("userId", shopId, "username");
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

        private void notification()
        {
            btn_success.Visible = true;

            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 2000,
                Enabled = true
            };

            timer.Elapsed += (timerSender, timerEvent) =>
            {
                btn_success.Visible = false; ;
                timer.Stop();
            };
            timer.Start();
        }
        #endregion

        private void pb_addToCart_Click(object sender, EventArgs e)
        {
            notification();

            main.dataSource.SetCollection("user");
            string temp = main.dataSource.findValue("loginName", main.currentUser, "cart");

            if(temp == "")
            {  temp += foodId; }
            else
            { temp += "-" + foodId; }

            main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", temp);
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("foodSubPage");
        }
    }
}
