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
    public partial class foodSlide : UserControl
    {
        mainForm main;
        public foodSlide(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            for (int i = 0; i < 4; i++)
            {
                foodBlock f = new foodBlock(main);
                flowLayoutPanel1.Controls.Add(f);
            }
        }
    }
}
