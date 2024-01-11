using CefSharp.DevTools.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component
{
    public partial class Login : UserControl
    {
        mainForm main;
        public Login(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            main.Close();
        }

        public void removeErrorText()
        {
            lb_error.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == "" || tb_username.Text == "")
            {
                lb_error.Text = "Vui lòng điền đầy đủ thông tin";
                return;
            }
            if(main.dataSource.checkLogIn(tb_username.Text, tb_password.Text))
            {
                main.currentUser = tb_username.Text;
                main.currentId = main.dataSource.findValue("loginName", main.currentUser, "userId");
                main.loginSuccess(false);
            }
            else
            {
                lb_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }

        private void lb_forgetPassword_Click(object sender, EventArgs e)
        {
            Random newPassword = new Random();
            if (tb_username.Text == "")
            {
                lb_error.Text = "Vui lòng điền đầy đủ thông tin";
                return;
            }
            if (main.dataSource.findValue("loginName",tb_username.Text ,"email") == "")
            {
                lb_error.Text = "Tên đăng nhập không tồn tại.";
                return;
            }

            int newpassword = newPassword.Next();
            main.dataSource.findAndReplaceOne("loginName", tb_username.Text, "password", newpassword.ToString());

            try
            {
                // Replace the following values with your Gmail email configuration
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string senderEmail = "nguyenvanlien3434@gmail.com";
                string senderPassword = "gywd yffv iylo mavv"; // Use "App Password" if two-factor authentication is enabled
                string recipientEmail = main.dataSource.findValue("loginName", tb_username.Text, "email");
                string subject = "Mật khẩu mới của bạn";
                string body = $"Chào {tb_username.Text} đây là mật khẩu mới của bạn :{newpassword}\n Dùng mật khẩu mới để đăng nhập nhé";

                using (SmtpClient smtpClient = new SmtpClient(smtpServer))
                {
                    smtpClient.Port = smtpPort;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body))
                    {
                        // You can add attachments, set the priority, etc., if needed

                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
