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
    public partial class testDatabase : Form
    {
        DataSource dataSource = new DataSource();
        public testDatabase()
        {
            InitializeComponent();
            dataSource.SetCollection("user");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = dataSource.returnAllData()[0].ToString();
        }
    }
}
