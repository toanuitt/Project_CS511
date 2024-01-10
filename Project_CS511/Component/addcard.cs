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
    public partial class addcard : UserControl
    {
       
        mainForm main;
        public addcard(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void lbl_QRcode_Click(object sender, EventArgs e)
        {
            onlinepayment pay = new onlinepayment(main);
            main.Controls.Add(pay);
            main.bringControlToFront(pay);
        }
    }
}
