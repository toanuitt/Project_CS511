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
    public partial class foodBlock : UserControl
    {
        mainForm main;
        public foodBlock(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        #region decoration
        private void pb_picture_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }

        private void pb_picture_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion

        private void pb_picture_Click(object sender, EventArgs e)
        {
            foodSubPage f = new foodSubPage(main);
            f.BringToFront();
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }
    }
}
