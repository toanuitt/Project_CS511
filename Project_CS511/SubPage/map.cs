using Project_CS511.Component;
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
    public partial class map : UserControl
    {
        mainForm main;
        public map(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        // allow user to open map to choose location
        private void btn_mapchoose_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.maplocationPage.Show();
            main.maplocationPage.getPage(number);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.ShowMenu();
            main.foodPage.Show();
        }
        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.mapPage != null) { main.mapPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        private int number =1;
        private void btn_recent_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            number = 1;
            btn_recent.BackColor = Color.LightCyan;
            btn_recent.ForeColor = Color.Green;
            btn_saved.BackColor = Color.White;
            btn_saved.ForeColor = Color.Gray;
            var newlocation = new location(main);
            flowLayoutPanel1.Controls.Add(newlocation);
            // add database recent to flowlayoutpanel1
        }

        private void btn_saved_Click(object sender, EventArgs e)
        {
            number = 2;
            btn_saved.BackColor = Color.LightCyan;
            btn_saved.ForeColor = Color.Green;
            btn_recent.BackColor = Color.White;
            btn_recent.ForeColor = Color.Gray;
            flowLayoutPanel1.Controls.Clear();
            var addlocation = new addLocation(main);
            flowLayoutPanel1.Controls.Add(addlocation);
           // add database saved to flowlayoutpanel1
        }
        public void getAddress(string address)
        {
            txtbox_address.Text = address;
        }
        private void map_Load(object sender, EventArgs e)
        {
            var newlocation = new location(main);
            flowLayoutPanel1.Controls.Add(newlocation);
        }
    }
}
