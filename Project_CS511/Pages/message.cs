using MongoDB.Bson;
using MongoDB.Driver;
using Project_CS511.Component;
using Project_CS511.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Pages
{
    public partial class message : UserControl
    {
        mainForm main;
        public bool hasSeen = false;
        Color green = Color.FromArgb(16, 83, 53);
        Color lightGreen = Color.FromArgb(181, 240, 214);
        public message(mainForm main=null)
        {
            InitializeComponent();
            this.main = main;
        }

        public void init()
        {

            lb_chat.BackColor = green;
            lb_notification.BackColor = lightGreen;
            flowLayoutPanel1.Controls.Clear();

            main.dataSource.SetCollection("notify");

            List<BsonDocument> allNotifies = main.dataSource.findMultipleDoc("userId", main.currentId);
            allNotifies.Reverse();

            if(allNotifies.Count > 0)
            {
                foreach(BsonDocument doc in allNotifies)
                {
                    chatBlock f = new chatBlock(main);
                    f.addData(doc);
                    flowLayoutPanel1.Controls.Add(f);
                }
            }

            main.dataSource.SetCollection("user");
        }

        public void setToAvoidConflict()
        {
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                chatBlock temp = (chatBlock)c;
                temp.setDefaultImage();
            }
        }

        public void setToSeen(bool seen)
        {
            if(seen)
            {
                main.dataSource.SetCollection("notify");

                main.dataSource.findAndReplaceMany("isnew", "1", "isnew", "0");
                init();

                main.dataSource.SetCollection("user");

            }
        }
        #region decorate
        private void lb_food_Click(object sender, EventArgs e)
        {
            pb_chat.Image = Resources.bubble_green;
            lb_chat.ForeColor = Color.White;
            lb_chat.BackColor = green;

            pb_notification.Image = Resources.bubble_lightGreen;
            lb_notification.ForeColor = green;
            lb_notification.BackColor = lightGreen;

            foreach(Control c in flowLayoutPanel1.Controls)
            {
                chatBlock temp = (chatBlock)c;
                c.Show();
            }
        }

        private void lb_notification_Click(object sender, EventArgs e)
        {
            pb_notification.Image = Resources.bubble_green;
            lb_notification.ForeColor = Color.White;
            lb_notification.BackColor = green;

            pb_chat.Image = Resources.bubble_lightGreen;
            lb_chat.ForeColor = green;
            lb_chat.BackColor = lightGreen;

            foreach(Control c in flowLayoutPanel1.Controls)
            {
                chatBlock temp = (chatBlock)c;
                if (temp.isnew == "1")
                {
                    temp.Show();
                }
                else
                    temp.Hide();
            }

        }
        #endregion

        private void pb_trash_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(c);
            }

            main.dataSource.deleteAll();
        }
    }
}
