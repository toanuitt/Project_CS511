using Project_CS511.Component;
using Project_CS511.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511
{
    public partial class mainForm : Form
    {
        public home homePage;
        public mainForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //add menu bar
            menuBar menu = new menuBar(this);
            this.Controls.Add(menu);

            //add home page
            homePage = new home(this);
            this.Controls.Add(homePage);
        }
    }
}
