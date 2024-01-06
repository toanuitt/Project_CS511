using Project_CS511.SubPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component.Cart
{
    public partial class addressBlock1 : UserControl
    {
        mainForm main;
        public addressBlock1(mainForm mainForm)
        {
            InitializeComponent();
            this.main = mainForm;
            init();
        }

        private void init()
        {
            main.dataSource.SetCollection("user");
            lb_phone.Text = main.dataSource.findValue("loginName", main.currentUser, "sdt");

            main.dataSource.SetCollection("tempData");
            lb_address.Text = main.dataSource.findValue("id", "1", "location");

            main.dataSource.SetCollection("user");
        }

        private void lb_address_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            main.maplocationPage.BringToFront();
            main.maplocationPage.Show();
        }

        public void updateAddress(string add)
        {
            lb_address.Text = add;
        }
    }
}
