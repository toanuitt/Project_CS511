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
        }
    }
}
