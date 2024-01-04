using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_CS511.SubPage
{
    public partial class maplocation : UserControl
    {
        mainForm main;
        public maplocation(mainForm main)
        {
            InitializeComponent();
            this.main = main;

        }

        private void maplocation_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(10.8231, 106.6297); // Initial coordinates
            gMapControl1.Zoom = 18;
            gMapControl1.MouseClick += GMapControl1_MouseClick;
        }
        private void GMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng clickedPoint = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                MessageBox.Show("Selected coordinates: " + clickedPoint.Lat + ", " + clickedPoint.Lng +"address"+e.Location);
            }
        }

    }
}
