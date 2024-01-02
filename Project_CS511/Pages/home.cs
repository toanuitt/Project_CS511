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

namespace Project_CS511.Pages
{
    public partial class home : UserControl
    {
        mainForm main;
        public home(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            adSlide adSlide = new adSlide();
            flp_home.Controls.Add(adSlide);

            foodSlide foodSlide = new foodSlide(main);
            flp_home.Controls.Add(foodSlide);
        }

        private void flp_home_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
