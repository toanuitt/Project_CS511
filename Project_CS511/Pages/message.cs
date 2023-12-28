using Project_CS511.Component;
using Project_CS511.Properties;
using System;
using System.Collections.Generic;
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
        Color green = Color.FromArgb(16, 83, 53);
        Color lightGreen = Color.FromArgb(181, 240, 214);
        public message(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        public void init()
        {
            flowLayoutPanel1.Controls.Add(new chatBlock());
            flowLayoutPanel1.Controls.Add(new chatBlock());
            flowLayoutPanel1.Controls.Add(new chatBlock());

            lb_chat.BackColor = green;
            lb_notification.BackColor = lightGreen;
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
        }

        private void lb_notification_Click(object sender, EventArgs e)
        {
            pb_notification.Image = Resources.bubble_green;
            lb_notification.ForeColor = Color.White;
            lb_notification.BackColor = green;

            pb_chat.Image = Resources.bubble_lightGreen;
            lb_chat.ForeColor = green;
            lb_chat.BackColor = lightGreen;
        }
        #endregion
    }
}
