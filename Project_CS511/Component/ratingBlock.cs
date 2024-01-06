using Amazon.Auth.AccessControlPolicy;
using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Properties;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component
{
    public partial class ratingBlock : UserControl
    {
        mainForm main;
        public string foodId;
        string rating;
        public ratingBlock(mainForm main, BsonDocument data = null)
        {
            InitializeComponent();
            this.main = main;
            if(data != null )
            {
                switch(data["rating"].AsString)
                {
                    case "1":
                        pictureBox1_Click(pictureBox1, EventArgs.Empty);
                        rating = "1";
                        break;
                    case "2":
                        pictureBox2_Click(pictureBox2, EventArgs.Empty);
                        rating = "2";
                        break;
                    case "3":
                        pictureBox3_Click(pictureBox3, EventArgs.Empty);
                        rating = "3";
                        break;
                    case "4":
                        pictureBox4_Click(pictureBox4, EventArgs.Empty);
                        rating = "4";
                        break;
                    case "5":
                        pictureBox5_Click(pictureBox5, EventArgs.Empty);
                        rating = "5";
                        break;
                }
                tb_comment.Text = data["comment"].AsString;
            }
            else
            {
                pictureBox5_Click(pictureBox5, EventArgs.Empty);
                rating = "5";
                tb_comment.Text = "";
            }
        }


        #region star click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.star_on;
            pictureBox2.Image = Resources.star_off;
            pictureBox3.Image = Resources.star_off;
            pictureBox4.Image = Resources.star_off;
            pictureBox5.Image = Resources.star_off;
            rating = "1";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.star_on;
            pictureBox2.Image = Resources.star_on;
            pictureBox3.Image = Resources.star_off;
            pictureBox4.Image = Resources.star_off;
            pictureBox5.Image = Resources.star_off;
            rating = "2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.star_on;
            pictureBox2.Image = Resources.star_on;
            pictureBox3.Image = Resources.star_on;
            pictureBox4.Image = Resources.star_off;
            pictureBox5.Image = Resources.star_off;
            rating = "3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.star_on;
            pictureBox2.Image = Resources.star_on;
            pictureBox3.Image = Resources.star_on;
            pictureBox4.Image = Resources.star_on;
            pictureBox5.Image = Resources.star_off;
            rating = "4";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.star_on;
            pictureBox2.Image = Resources.star_on;
            pictureBox3.Image = Resources.star_on;
            pictureBox4.Image = Resources.star_on;
            pictureBox5.Image = Resources.star_on;
            rating = "5";
        }
        #endregion

        private void btn_updateUsername_Click(object sender, EventArgs e)
        {
            main.dataSource.SetCollection("foodComment");
            //filter definition
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("loginName", main.currentUser),
                Builders<BsonDocument>.Filter.Eq("foodId", foodId)
            );
            //find comment
            List<BsonDocument> comment = main.dataSource.findWithFilter(filter);

            //if comment exist
            if(comment.Count > 0)
            {
                //update comment
                updateComment(comment[0]);
            }
            else
            {
                //add new comment
                addNewComment();
            }    
            //refresh
            foodSubPage foodSubPage = (foodSubPage)this.Parent;
            foodSubPage.refreshComment();
        }

        private void addNewComment()
        {
            main.dataSource.SetCollection("foodComment");

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");

            BsonDocument newComment = new BsonDocument
            {
                {"loginName", main.currentUser },
                {"foodId", foodId},
                {"commentId", (main.dataSource.getLength()+1).ToString() },
                {"rating", rating },
                {"time", formattedDate },
                {"comment", tb_comment.Text },
            };
            main.dataSource.insertToCollection(newComment);
            main.dataSource.SetCollection("user");
        }

        private void updateComment(BsonDocument foodCommentBson)
        {
            main.dataSource.SetCollection("foodComment");
            main.dataSource.findAndReplaceOne("commentId", foodCommentBson["commentId"].AsString, "rating", rating);
            main.dataSource.findAndReplaceOne("commentId", foodCommentBson["commentId"].AsString, "comment", tb_comment.Text);
            main.dataSource.SetCollection("user");
        }
    }
}
