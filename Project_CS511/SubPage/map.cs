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
        #region hide usercontrol
        public void hideAllControls()
        {
            this.Controls.Clear();
            if (main.mapPage != null) { main.mapPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
    }
}
