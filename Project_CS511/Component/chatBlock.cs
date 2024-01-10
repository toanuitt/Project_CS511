using MongoDB.Bson;
using Project_CS511.Properties;
using System;
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
    public partial class chatBlock : UserControl
    {
        mainForm main;
        string pictureName = "-1";
        string id;
        public string isnew;
        public chatBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void addData(BsonDocument doc)
        {
            if (doc["isnew"].AsString == "1")
            {
                this.BackColor = Color.NavajoWhite;
            }
            lb_messageType.Text = doc["notifyType"].AsString;
            lb_chat.Text = doc["content"].AsString;
            lb_time.Text = doc["date"].AsString;

            pictureName = doc["pictureName"].AsString;
            id = doc["id"].AsString;
            isnew = doc["isnew"].AsString;

            if(doc["notifyType"].AsString == "Order Placed")
            {
                pb_avatar.Image = Image.FromFile(getAvatarPath() + pictureName + ".png");
            }
            if (doc["notifyType"].AsString == "Product Added")
            {
                pb_avatar.Image = Resources.add_food;
            }
            if (doc["notifyType"].AsString == "Product Deleted")
            {
                pb_avatar.Image = Resources.delete_food;
            }

        }

        public void orderNotify(string shopName, string price, string shopId)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999);
            pictureName = shopId;

            lb_messageType.Text = "Order Placed";
            lb_chat.Text = $"You have successfully place order at {shopName}, your total bill is {price}, your order id{randomNumber}";

            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy HH:mm");
            lb_time.Text = formattedDateTime;

            addToData();

        }

        public void deletedNotify(string productName)
        {
            lb_messageType.Text = "Product Deleted";
            lb_chat.Text = $"You have successfully delete the following product {productName}";

            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy HH:mm:ss");
            lb_time.Text = formattedDateTime;

            addToData();
        }

        public void addNotify(string productName)
        {
            lb_messageType.Text = "Product Added";
            lb_chat.Text = $"You have successfully added the following product {productName}";

            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy HH:mm");
            lb_time.Text = formattedDateTime;

            addToData();
        }

        #region cac ham chuc nang
        private void addToData()
        {
            main.dataSource.SetCollection("genericInfo");
            int newMaxId = Int32.Parse(main.dataSource.findValue("id", "1", "maxNotifyId")) + 1;
            main.dataSource.findAndReplaceOne("id", "1", "maxNotifyId", newMaxId.ToString());

            main.dataSource.SetCollection("notify");

            BsonDocument newNotify = new BsonDocument
            {
                {"id",newMaxId.ToString() },
                {"userId", main.currentId },
                {"notifyType", lb_messageType.Text },
                {"content", lb_chat.Text},
                {"date", lb_time.Text },
                {"pictureName", pictureName },
                {"isnew", "1" }
            };
            main.dataSource.insertToCollection(newNotify);
            main.dataSource.SetCollection("user");
        }

        private void removeFromData()
        {
            main.dataSource.SetCollection("notify");

            main.dataSource.deleteOneByValue("id", id);

            main.dataSource.SetCollection("user");
        }

        private string getAvatarPath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\avatar\\";
            return currentPath;
        }

        public void setDefaultImage()
        {
            pb_avatar.Image.Dispose();
            pb_avatar.Image = Resources._default;
        }

        #endregion
        #region decorate
        private void pb_avatar_MouseEnter(object sender, EventArgs e)
        {
            if (isnew != "1")
                BackColor = Color.LightGray;
            else
                BackColor = Color.Tan;
        }

        private void lb_time_MouseLeave(object sender, EventArgs e)
        {
            if (isnew != "1")
                BackColor = Color.White;
            else
                BackColor = Color.NavajoWhite;
        }
        #endregion

        private void pb_trash_Click(object sender, EventArgs e)
        {
            removeFromData();
            this.Parent.Controls.Remove(this);
        }
    }
}
