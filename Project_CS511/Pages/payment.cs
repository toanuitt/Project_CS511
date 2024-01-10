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
    public partial class payment : UserControl
    {
        mainForm main;
        public payment(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void lbl_QRcode_Click(object sender, EventArgs e)
        {
            onlinepayment pay = new onlinepayment(main);
            main.Controls.Add(pay);
            main.bringControlToFront(pay);
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck the other checkbox when one is checked
            if (sender == checkBox1 && checkBox1.Checked)
            {
                checkBox2.Checked = false;
                main.methodepayment = "1";
            }
            else if (sender == checkBox2 && checkBox2.Checked)
            {
                checkBox1.Checked = false;
                main.methodepayment = "2";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
