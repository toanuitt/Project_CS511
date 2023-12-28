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
    public partial class chatBlock : UserControl
    {
        public chatBlock()
        {
            InitializeComponent();
        }

        #region decorate
        private void pb_avatar_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void lb_time_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion
    }
}
