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
    public partial class menuBar : UserControl
    {
        //khai báo biến kiểu mainForm để kết nối usercontrol với form chính
        mainForm main;
        Color green = Color.FromArgb(14, 153, 49);
        public menuBar(mainForm mainForm)
        {
            InitializeComponent();
            lb_home.ForeColor = green;

            //kết nối với form chính
            main = mainForm;
        }

        #region decoration
        private void setColorBack()
        {
            //set label color
            lb_home.ForeColor = Color.Black;
            lb_account.ForeColor = Color.Black;
            lb_food.ForeColor = Color.Black;
            lb_message.ForeColor = Color.Black;
            lb_payment.ForeColor = Color.Black;
            //set image to nonactive
            pb_home.Image = Resources.compass;
            pb_account.Image = Resources.customer;
            pb_food.Image = Resources.food;
            pb_message.Image = Resources.chat;
            pb_payment.Image = Resources.wallet;
        }

        private void lb_home_Click(object sender, EventArgs e)
        {
            setColorBack();
            hideAllControls();
            main.homePage.Show();
            lb_home.ForeColor = green;
            pb_home.Image = Resources.compass_active;
        }

        private void pb_food_Click(object sender, EventArgs e)
        {
            setColorBack();
            hideAllControls();
            main.foodPage.Show();
            main.foodPage.Init();
            lb_food.ForeColor = green;
            pb_food.Image = Resources.food_active;
        }

        private void pb_payment_Click(object sender, EventArgs e)
        {
            setColorBack();
            hideAllControls();
            main.paymentPage.Show();
            lb_payment.ForeColor = green;
            pb_payment.Image = Resources.wallet_active;
        }

        private void pb_message_Click(object sender, EventArgs e)
        {
            setColorBack();
            hideAllControls();
            main.messagePage.Show();
            lb_message.ForeColor = green;
            pb_message.Image = Resources.chat_active;
        }

        private void pb_account_Click(object sender, EventArgs e)
        {
            setColorBack();
            hideAllControls();
            main.accountPage.Show();
            main.accountPage.reloadAvatar();
            lb_account.ForeColor = green;
            pb_account.Image = Resources.customer_active;
        }

        #endregion

        #region hide usercontrol
        public void hideAllControls()
        {
            if(main.homePage != null)
            {
                main.homePage.Hide();
            }
            if (main.messagePage != null) { main.messagePage.Hide(); }
            if (main.accountPage != null) { main.accountPage.Hide(); }
            if (main.paymentPage != null) { main.paymentPage.Hide(); }
            if (main.foodPage != null) { main.foodPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion

    }
}
