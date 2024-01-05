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
                main.loginSuccess();
            }
            else
            {
                lb_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }
    }
}
