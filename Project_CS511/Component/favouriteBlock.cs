using MongoDB.Bson;
using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_CS511.Component
{
    public partial class favouriteBlock : UserControl
    {
        mainForm main;
        string thisfoodId;
        public favouriteBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void addData(string foodId)
        {
            thisfoodId = foodId;
            main.dataSource.SetCollection("food");
            lb_name.Text = main.dataSource.findValue("foodId", foodId, "foodName");
            pb_picture.Image = Image.FromFile(getFoodPicturePath() + foodId + ".png");

            string userId = main.dataSource.findValue("foodId", foodId, "shopId");
            main.dataSource.SetCollection("user");
            lb_store.Text = main.dataSource.findValue("loginName", main.currentUser, "username");
        }

        #region cac ham chuc nang
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

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
        private void pb_like_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel parent = (FlowLayoutPanel)this.Parent;
            Control controlToRemove = parent.Controls.Find(Name, true).FirstOrDefault();
            parent.Controls.Remove(controlToRemove);
            removeFromLiked(thisfoodId);
        }



    }
}
