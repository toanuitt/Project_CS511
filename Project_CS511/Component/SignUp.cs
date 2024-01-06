using MongoDB.Bson;
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

namespace Project_CS511.Component
{
    public partial class SignUp : UserControl
    {
        mainForm main;
        public SignUp(mainForm main)
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

        private void btn_dangKi_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_password.Text == "" || tb_password2.Text == "")
            {
                lb_error.Text = "Please Lilling In All Infomation";
                return;
            }
            if (tb_password.Text != tb_password2.Text)
            {
                lb_error.Text = "Passwords Not Match";
                return;
            }
            if (!IsEmailValid(tb_email.Text))
            {
                lb_error.Text = "Invalid Email";
                return;
            }
            if (!IsNumeric(tb_sdt.Text))
            {
                lb_error.Text = "Invalid Phone Number";
                return;
            }

            main.dataSource.SetCollection("user");
            if (main.dataSource.findValue("loginName", tb_username.Text, "loginName") != "")
            {
                lb_error.Text = "Username Already Exist";
                return;
            }
            //Tạo thông tin cần thêm vào
            BsonDocument newUserInfo = new BsonDocument
            {
                {"loginName", tb_username.Text },
                {"username", tb_username.Text },
                {"email", tb_email.Text},
                {"sdt", tb_sdt.Text },
                {"password", tb_password.Text },
                {"location", "" },
                {"userId", (main.dataSource.getLength()+1).ToString() },
                {"coordinate", ""},
                {"cart", "" },
                {"boughtFood", ""}
            };

            //thêm dữ liệu vào database (lưu ý collection phải là user do đang cần thêm người dùng)

            //nếu không chắc có thể đặt lại collection
            main.dataSource.SetCollection("user");

            //thêm vào database
            main.dataSource.insertToCollection(newUserInfo);

            main.loginSuccess();
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
    }
}
