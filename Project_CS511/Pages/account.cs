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

namespace Project_CS511.Pages
{
    public partial class account : UserControl
    {
        mainForm main;
        Color green = Color.FromArgb(16, 83, 53);
        public account(mainForm main=null)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        public void init()
        {
            panel1.BackColor = green;
            lb_logOut.BackColor = green;
        }

        #region decoration
        #region mouse Enter
        private void lb_changeUsername_MouseEnter(object sender, EventArgs e)
        {
            pn_changeUsername.BackColor = Color.LightGray;
        }

        private void lb_changePassword_MouseEnter(object sender, EventArgs e)
        {
            pn_changePassword.BackColor = Color.LightGray;
        }

        private void lb_payment_MouseEnter(object sender, EventArgs e)
        {
            pn_payment.BackColor = Color.LightGray;
        }

        private void lb_favourites_MouseEnter(object sender, EventArgs e)
        {
            pn_favourites.BackColor = Color.LightGray;
        }

        private void lb_savedPlaces_MouseEnter(object sender, EventArgs e)
        {
            pn_savedPlaces.BackColor = Color.LightGray;
        }
        #endregion

        #region mouse Leave
        private void pn_changeUsername_MouseLeave(object sender, EventArgs e)
        {
            pn_changeUsername.BackColor = Color.White;
        }

        private void pn_changePassword_MouseLeave(object sender, EventArgs e)
        {
            pn_changePassword.BackColor = Color.White;
        }

        private void pn_payment_MouseLeave(object sender, EventArgs e)
        {
            pn_payment.BackColor = Color.White;
        }

        private void pn_favourites_MouseLeave(object sender, EventArgs e)
        {
            pn_favourites.BackColor = Color.White;
        }

        private void pn_savedPlaces_MouseLeave(object sender, EventArgs e)
        {
            pn_savedPlaces.BackColor = Color.White;
        }


        #endregion

        #endregion

        private void lb_logOut_Click(object sender, EventArgs e)
        {
            main.Close();
        }

        private void lb_updateInfo_Click(object sender, EventArgs e)
        {
            updateInfo f = new updateInfo(main);
            main.Controls.Add(f);
            main.bringControlToFront(f);
        }

        private void pn_changeUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_yourLocation_Click(object sender, EventArgs e)
        {
            setLocation location = new setLocation(main);
            main.Controls.Add(location);
            main.bringControlToFront(location);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pn_changePassword_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
