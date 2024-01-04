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
using System.Net;
using Newtonsoft.Json;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

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
            string api_key = "AIzaSyBSYbQZksuYN9M8fbvOMzOfHKITwHcSyxg";
            richTextBox1.Text = GetAddressFromLatLng(10.8231, 106.6297, api_key);
            label1.Text = richTextBox1.Text.Split(',')[0].Trim();
            markerOverlay.Markers.Clear();

            // Create a new marker
            GMarkerGoogle marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            // Add the overlay to the map
            if (!gMapControl1.Overlays.Contains(markerOverlay))
            {
                gMapControl1.Overlays.Add(markerOverlay);
            }
        }
        #region Các Hàm chức năng
        private GMapOverlay markerOverlay = new GMapOverlay("markers");
        // user choose the location by left click and move map by hole right click
        // zoom in and zoom out by scroll 
        private void GMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng clickedPoint = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                //string address = GetAddressFromLatLng(clickedPoint.Lat, clickedPoint.Lng, apiKey);
                string api_key = "AIzaSyBSYbQZksuYN9M8fbvOMzOfHKITwHcSyxg";
                richTextBox1.Text = GetAddressFromLatLng(clickedPoint.Lat, clickedPoint.Lng, api_key);
                label1.Text = richTextBox1.Text.Split(',')[0].Trim();
                // Clear existing markers before placing a new one
                markerOverlay.Markers.Clear();

                // Create a new marker
                GMarkerGoogle marker = new GMarkerGoogle(clickedPoint, GMarkerGoogleType.red);
                markerOverlay.Markers.Add(marker);

                // Add the overlay to the map
                if (!gMapControl1.Overlays.Contains(markerOverlay))
                {
                    gMapControl1.Overlays.Add(markerOverlay);
                }
            }
        }
        // get address by api_key
        static string GetAddressFromLatLng(double latitude, double longitude, string apiKey)
        {
            string apiUrl = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}";

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                string json = wc.DownloadString(apiUrl);

                // Parse the JSON response
                dynamic result = JsonConvert.DeserializeObject(json);

                // Check if the response status is OK
                if (result.status == "OK")
                {
                    // Get the formatted address
                    string formattedAddress = result.results[0].formatted_address;
                    return formattedAddress;
                }
                else
                {
                    // Handle error cases
                    Console.WriteLine("Error: " + result.status);
                    return null;
                }
            }
        }
        #endregion

        #region Chuyển dữ liệu

        #endregion

        private void btn_confirmlocation_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.mapPage.Show();
        }
        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.maplocationPage != null)
            {
                main.maplocationPage.Hide();
            }
           
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
    }
}
