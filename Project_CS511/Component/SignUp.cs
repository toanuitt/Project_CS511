using MongoDB.Bson;
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
            if(tb_username.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_password.Text == "" || tb_password2.Text =="")
            {
                lb_error.Text = "Vui lòng nhập đầy đủ thông tin";
                return;
            }
            if(tb_password.Text != tb_password2.Text)
            {
                lb_error.Text = "Mật khẩu không khớp";
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
            };

            //thêm dữ liệu vào database (lưu ý collection phải là user do đang cần thêm người dùng)

            //nếu không chắc có thể đặt lại collection
            main.dataSource.SetCollection("user");

            //thêm vào database
            main.dataSource.insertToCollection(newUserInfo);

            main.loginSuccess();
        }
    }
}
