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
    }
}
