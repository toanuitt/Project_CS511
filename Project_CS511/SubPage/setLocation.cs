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
using System.Timers;
using System.IO;

namespace Project_CS511.SubPage
{
    public partial class setLocation : UserControl
    {
        bool isNewUser = false;
        mainForm main;
        string coordinate;
        string location;
        public setLocation(mainForm main)
        {
            InitializeComponent();
            this.main = main;

        }

        private void maplocation_Load(object sender, EventArgs e)
        {

            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            main.dataSource.SetCollection("user");
            string address = main.dataSource.findValue("loginName", main.currentUser, "location");
            if (address != "")
            {
                var (latitude, longitude) = GetLatLngFromAddress(address, main.api_key);
                gMapControl1.Position = new PointLatLng(latitude, longitude); // Initial coordinates
                richTextBox1.Text = GetAddressFromLatLng(latitude, longitude, main.api_key);
            }
            else
            {
                gMapControl1.Position = new PointLatLng(10.8231, 106.6297);
                richTextBox1.Text = GetAddressFromLatLng(10.8231, 106.6297, main.api_key);
            }

            gMapControl1.Zoom = 18;
            gMapControl1.MouseClick += GMapControl1_MouseClick;


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
                btn_confirmlocation.Enabled = true;
                PointLatLng clickedPoint = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                //string address = GetAddressFromLatLng(clickedPoint.Lat, clickedPoint.Lng, apiKey);
                    
                richTextBox1.Text = GetAddressFromLatLng(clickedPoint.Lat, clickedPoint.Lng, main.api_key);
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

                location = richTextBox1.Text;
                coordinate = clickedPoint.Lat.ToString() + "-" + clickedPoint.Lng.ToString();

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

        private void notification()
        {
            btn_success.Visible = true;

            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 3000,
                Enabled = true
            };

            timer.Elapsed += (timerSender, timerEvent) =>
            {
                // Hide the button after 3 seconds
                btn_success.Visible = false; ;

                // Stop the timer
                timer.Stop();
            };
            timer.Start();
        }

        public void ModeNew()
        {
            btn_back.Hide();
            isNewUser = true;
        }
        #endregion

        private void btn_confirmlocation_Click(object sender, EventArgs e)
        {
            notification();
            main.dataSource.SetCollection("user");
            main.dataSource.findAndReplaceOne("loginName", main.currentUser, "coordinate", coordinate);
            main.dataSource.findAndReplaceOne("loginName", main.currentUser, "location", location);
            if(isNewUser)
            {
                main.RemoveControlByName("setLocation");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("setLocation");
        }
        #region get address
        static (double Latitude, double Longitude) GetLatLngFromAddress(string address, string apiKey)
        {
            if(address == "")
                address = "RM67 + 4X6, Trường Sơn, Phường 2, Tân Bình, Thành phố Hồ Chí Minh, Vietnam";
            string encodedAddress = Uri.EscapeDataString(address);
            string apiUrl = $"https://maps.googleapis.com/maps/api/geocode/json?address={encodedAddress}&key={apiKey}";

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                string json = wc.DownloadString(apiUrl);

                // Parse the JSON response
                dynamic result = JsonConvert.DeserializeObject(json);

                // Check if the response status is OK
                if (result.status == "OK")
                {
                    // Get the latitude and longitude
                    double latitude = result.results[0].geometry.location.lat;
                    double longitude = result.results[0].geometry.location.lng;

                    return (latitude, longitude);
                }
                else
                {
                    // Handle error cases
                    Console.WriteLine("Error: " + result.status);
                    return (0, 0); // Return a default value or handle the error accordingly
                }
            }
        }
        #endregion

    }
}
