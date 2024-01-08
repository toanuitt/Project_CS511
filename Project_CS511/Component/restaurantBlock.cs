using MongoDB.Bson;
using Project_CS511.Properties;
using Project_CS511.SubPage;
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

namespace Project_CS511.Component
{
    public partial class restaurantBlock : UserControl
    {
        mainForm main;
        string userId;
        public restaurantBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        #region decoration
        private void pb_picture_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }

        private void pb_picture_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion

        public void addData(BsonDocument doc)
        {
            main.dataSource.SetCollection("user");
            string path = getAvatarPath();
            userId = doc["userId"].AsString;

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

            //add food name
            lb_name.Text = doc["username"].AsString;

        }

        #region cac ham chuc nang
        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;

        }
        #endregion

        private void pb_picture_Click(object sender, EventArgs e)
        {
            shop f = new shop(main, userId);
            main.Controls.Add(f);
            main.bringControlToFront(f);

        }

        private void restaurantBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
