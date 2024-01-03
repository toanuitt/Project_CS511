using Project_CS511.Component;
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

namespace Project_CS511.SubPage
{
    public partial class logSignIn : UserControl
    {
        mainForm main;
        SignUp signUp;
        Login login;
        Color green = Color.FromArgb(16, 83, 53);
        Color lightGreen = Color.FromArgb(181, 240, 214);
        public logSignIn(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            signUp = new SignUp(main);
            this.Controls.Add(signUp);
            
            login = new Login(main);
            this.Controls.Add(login);

            signUp.Hide();

            lb_chat.BackColor = green;
            lb_notification.BackColor = lightGreen;
        }

        #region decoration
        private void lb_chat_Click(object sender, EventArgs e)
        {
            login.Show();
            login.removeErrorText();
            signUp.Hide();

            pb_chat.Image = Resources.bubble_green;
            lb_chat.ForeColor = Color.White;
            lb_chat.BackColor = green;

            pb_notification.Image = Resources.bubble_lightGreen;
            lb_notification.ForeColor = green;
            lb_notification.BackColor = lightGreen;
        }

        private void lb_notification_Click_1(object sender, EventArgs e)
        {
            signUp.Show();
            signUp.removeErrorText();
            login.Hide();

            pb_notification.Image = Resources.bubble_green;
            lb_notification.ForeColor = Color.White;
            lb_notification.BackColor = green;

            pb_chat.Image = Resources.bubble_lightGreen;
            lb_chat.ForeColor = green;
            lb_chat.BackColor = lightGreen;
            panel2.Hide();
        }
        #endregion


    }
}
