using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Component;
using Project_CS511.Properties;
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
        bool liked = false;
        public foodSubPage(mainForm main)
        {
            InitializeComponent();
            this.main = main;
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

            //add comment
            addComment(foodId);

            //add rating block
            addRatingBlock(foodId);

            //add heart
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();
            if(likedProduct.Contains(foodId))
            {
                pb_like.Image = Resources.heart_on;
                liked = true;
            }
        }

        #region add Data
        public void addComment(string foodId)
        {
            main.dataSource.SetCollection("foodComment");

            List<BsonDocument> comments = main.dataSource.findMultipleDoc("foodId", foodId);
            foreach (BsonDocument comment in comments)
            {
                foodCommentBubble foodCommentBubble = new foodCommentBubble(main);
                foodCommentBubble.addData(comment);
                flowLayoutPanel1.Controls.Add(foodCommentBubble);

            }
            main.dataSource.SetCollection("user");
        }

        public void addRatingBlock(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> boughtProduct = main.dataSource.findValue("loginName", main.currentUser, "boughtFood").Split('-').ToList();
            //no product bought yet
            if (boughtProduct[0] == "")
                return;
            
            //not buy food yet
            if(!boughtProduct.Contains(foodId)) return;

            main.dataSource.SetCollection("foodComment");
            //filter definition
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("loginName", main.currentUser),
                Builders<BsonDocument>.Filter.Eq("foodId", foodId)
            );
            //find document
            List<BsonDocument> commentData = main.dataSource.findWithFilter(filter);

            if(commentData.Count > 0)
            {
                ratingBlock ratingBlock = new ratingBlock(main, commentData[0]);
                ratingBlock.foodId = foodId;
                this.Controls.Add(ratingBlock);
            }
            else
            {
                ratingBlock ratingBlock = new ratingBlock(main, null);
                ratingBlock.foodId = foodId;
                this.Controls.Add(ratingBlock);
            }

            main.dataSource.SetCollection("user");
        }

        public void addHeart(string foodId)
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();

            if(likedProduct.Contains(foodId))
            {
                pb_like.Image = Resources.heart_on;
                liked = true;
            }
        }
        #endregion

        public void refreshComment()
        {
            flowLayoutPanel1.Controls.Clear();
            addComment(foodId);
        }
        private void pb_addToCart_Click(object sender, EventArgs e)
        {
            notification();

            main.dataSource.SetCollection("user");
            string temp = main.dataSource.findValue("loginName", main.currentUser, "cart");

            if (temp == "")
            { temp += foodId; }
            else
            { temp += "-" + foodId; }

            main.dataSource.findAndReplaceOne("loginName", main.currentUser, "cart", temp);
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
                btn_success.Visible = false; ;
                timer.Stop();
            };
            timer.Start();
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
                string newLiked = main.dataSource.findValue("loginName", main.currentUser, "liked") + "-" +foodId;
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "liked", newLiked);
            }      
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
        private void pb_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("foodSubPage");
        }

        private void pb_like_Click(object sender, EventArgs e)
        {
            if(liked)
            {
                pb_like.Image = Resources.heart_off;
                removeFromLiked(foodId);
                liked = false;
            }
            else
            {
                pb_like.Image = Resources.heart_on;
                addToLiked(foodId);
                liked = true;
            }
        }
    }
}
