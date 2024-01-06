using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.SubPage
{
    public partial class updateInfo : UserControl
    {
        mainForm main;
        public updateInfo(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }
        private void init()
        {
            main.dataSource.SetCollection("user");
            tb_username.Text = main.currentUser;
            tb_name.Text = main.dataSource.findValue("loginName", main.currentUser, "username");
            tb_phone.Text = main.dataSource.findValue("loginName", main.currentUser, "sdt");
            tb_email.Text = main.dataSource.findValue("loginName", main.currentUser, "email");
        }


        #region Các hàm chức năng
        static bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        static bool IsNumeric(string str)
        {
            if (int.TryParse(str, out _))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region button click
        private void btn_updateUsername_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                lb_usernameError.ForeColor = Color.Firebrick;
                lb_usernameError.Text = "Please Enter New Username";
                return;
            }
            if (main.dataSource.findValue("loginName", tb_username.Text, "loginName") != "")
            {
                lb_usernameError.ForeColor = Color.Firebrick;
                lb_usernameError.Text = "Username Already Exist";
            }
            else
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "loginName", tb_username.Text);

                main.dataSource.SetCollection("location");
                main.dataSource.findAndReplaceMany("userid", main.currentUser, "userid", tb_username.Text);
                main.dataSource.SetCollection("user");


                main.currentUser = tb_username.Text;
                lb_usernameError.ForeColor = Color.DarkGreen;
                lb_usernameError.Text = "Update Sucess";
            }
        }

        private void btn_updateName_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                lb_nameError.ForeColor = Color.Firebrick;
                lb_nameError.Text = "Please Enter New Name";
            }
            else
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "username", tb_name.Text);
                lb_nameError.ForeColor = Color.DarkGreen;
                lb_nameError.Text = "Update Sucess";
            }
        }

        private void btn_updatePhone_Click(object sender, EventArgs e)
        {
            if (tb_phone.Text == "")
            {
                lb_phoneError.ForeColor = Color.Firebrick;
                lb_phoneError.Text = "Please Enter New Phone Number";
                return;
            }
            if (!IsNumeric(tb_phone.Text))
            {
                lb_phoneError.ForeColor = Color.Firebrick;
                lb_phoneError.Text = "Invalid Phone Number";
            }
            else
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "sdt", tb_phone.Text);
                lb_phoneError.ForeColor = Color.DarkGreen;
                lb_phoneError.Text = "Update Sucess";
            }
        }

        private void btn_updateEmail_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                lb_emailError.ForeColor = Color.Firebrick;
                lb_emailError.Text = "Please Enter New Email";
                return;
            }
            if (!IsEmailValid(tb_email.Text))
            {
                lb_emailError.ForeColor = Color.Firebrick;
                lb_emailError.Text = "Invalid Email";
            }
            else
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "email", tb_email.Text);
                lb_emailError.ForeColor = Color.DarkGreen;
                lb_emailError.Text = "Update Sucess";
            }
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {

            if (tb_oldPassword.Text == "")
            {
                lb_passwordError.ForeColor = Color.Firebrick;
                lb_passwordError.Text = "Please Enter Old Password";
                return;
            }
            if (tb_newPassword.Text == "")
            {
                lb_passwordError.ForeColor = Color.Firebrick;
                lb_passwordError.Text = "Please Enter New Password";
                return;
            }

            if (tb_oldPassword.Text != main.dataSource.findValue("loginName", main.currentUser, "password"))
            {
                lb_passwordError.ForeColor = Color.Firebrick;
                lb_passwordError.Text = "Wrong Password";
            }
            else
            {
                main.dataSource.findAndReplaceOne("loginName", main.currentUser, "password", tb_newPassword.Text);
                lb_passwordError.ForeColor = Color.DarkGreen;
                lb_passwordError.Text = "Update Sucess";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("updateInfo");
        }
        #endregion


    }
}
