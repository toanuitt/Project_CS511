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
    public partial class restaurantBlock : UserControl
    {
        public restaurantBlock()
        {
            InitializeComponent();
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
    }
}
