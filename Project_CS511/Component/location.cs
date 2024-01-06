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

namespace Project_CS511.Component
{
    public partial class location : UserControl
    {
        mainForm main;
        public location(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.mapPage != null) { main.mapPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        private void btn_choose_Click(object sender, EventArgs e)
        {
            string newLocation = richtxtbox_address.Text;
            main.dataSource.SetCollection("tempData");
            string oldLocation = main.dataSource.findValue("id", "1", "location");
            main.dataSource.findAndReplaceOne("location", oldLocation, "location", newLocation);
            main.dataSource.SetCollection("user");

            main.foodPage.SetLabelAddress(richtxtbox_address.Text.Split(',')[0].Trim());
            main.foodPage.userlocation = richtxtbox_address.Text;
            hideAllControls();
            main.ShowMenu();
            main.foodPage.Show();
        }
        public void passaddress(string address)
        {
            richtxtbox_address.Text = address;
            btn_choose.Image = Properties.Resources.aim;
            label1.Text = "Current location";
        }
        public void passhistoryaddress(string address)
        {
            richtxtbox_address.Text = address;
            label1.Text = address.Split(',')[0].Trim();
        }
    }
}

