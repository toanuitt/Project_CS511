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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            main.dataSource.SetCollection("user");
            string userlocation = main.dataSource.findValue("loginName", main.currentUser, "location");
            var (time, distance) = main.foodPage.getDistance(userlocation, address);
            richtxtbox_address.Text = distance + ":" + address;
            label1.Text = address.Split(',')[0].Trim();
        }
        public void passrecommendaddress(string address)
        {
            main.dataSource.SetCollection("user");
            string userlocation = main.dataSource.findValue("loginName", main.currentUser, "location");
            var (time, distance) = main.foodPage.getDistance(userlocation, address);
            richtxtbox_address.Text = distance + ":" + address;
            label1.Text = address.Split(',')[0].Trim();
            btn_choose.Image = Properties.Resources.location;
        }
    }
}

