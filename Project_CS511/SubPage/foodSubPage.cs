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
            if (dataFood["shopId"].AsString == main.currentId)
            {
                pb_addToCart.Visible = false;
            }
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

            //addRating
            lb_star.Text = dataFood["rating"].AsString;

            //location
            addDistance(shopId);
        }
        #region foodpage
        public void addDataFoodpage(string idshop,string idfood,string namefood,string money, string rating)
        {
            string path = getFoodPicturePath();
            string shopId = idshop;//dataFood["shopId"].AsString;

            foodId = idfood;

            //add image
            pb_food.Image = Image.FromFile(path + idfood + ".png");

            //add food name
            lb_name.Text = namefood;

            //add money 
            lb_price.Text = FormatMoney(money) + "₫";

            //add shop name
            main.dataSource.SetCollection("user");
            lb_store.Text = main.dataSource.findValue("userId", shopId, "username");

            //add comment
            addComment(foodId);

            //add rating block
            addRatingBlock(foodId);

            //add heart
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();
            if (likedProduct.Contains(foodId))
            {
                pb_like.Image = Resources.heart_on;
                liked = true;
            }

            //add rating
            lb_star.Text = rating;
        }
        #endregion
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



        public void updateRating(string foodId)
        {
            main.dataSource.SetCollection("food");

            lb_star.Text = main.dataSource.findValue("foodId", foodId, "rating");

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
