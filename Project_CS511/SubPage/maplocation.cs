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
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;

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
                main.foodPage.currentuser.Latitude = clickedPoint.Lat;
                main.foodPage.currentuser.Longitude = clickedPoint.Lng;

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
        // convert address into latitude and longtitude
        static (double Latitude, double Longitude) GetLatLngFromAddress(string address, string apiKey)
        {
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

        private void updateLocationForCart()
        {
            Control control = main.findControlByName("cartSubPage");
            if (main.findControlByName("cartSubPage") != null)
            {
                cartSubPage cartSubPage = (cartSubPage)control;
                cartSubPage.updateAddress(richTextBox1.Text);
                hideAllControls();
            }
            else
            {
                hideAllControls();
                main.ShowMenu();
                main.foodPage.Show();
            }
        }
        #endregion

        #region Chuyển dữ liệu

        #endregion

        //know for recent number=1 and save number=2
        private int number;
        public void getPage(int num)
        {
            number = num;
        }
        private void btn_confirmlocation_Click(object sender, EventArgs e)
        {
            main.foodPage.currentuser.Address = richTextBox1.Text;
            main.foodPage.SetLabelAddress(label1.Text);
            hideAllControls();
            if (number == 1)
            {
                main.ShowMenu();
                main.foodPage.Show();
                IMongoCollection<BsonDocument> collections = main.dataSource.data.GetCollection<BsonDocument>("location");

                // Define a filter to find documents with the specified userid and location
                var filter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("userid", main.currentUser),
                    Builders<BsonDocument>.Filter.Eq("location", richTextBox1.Text)
                );

                // Check if a document with the specified userid and location exists
                var existingDocument = collections.Find(filter).FirstOrDefault();

                if (existingDocument != null)
                {
                    // If document exists, delete it
                    collections.DeleteOne(filter);
                }

                // Add a new document to the collection
                var newLocationDocument = new BsonDocument
                {
                    { "userid", main.currentUser },
                    { "location", richTextBox1.Text }
                };

                collections.InsertOne(newLocationDocument);

            }
            else
            {
                main.mapPage.Show();
                // add location to database 
            }
            updateLocationForCart();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.mapPage.Show();
        }
        public void Init()
        {
            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
          
            string address = main.foodPage.userlocation;
            var (latitude, longitude) = GetLatLngFromAddress(address, main.api_key);
            gMapControl1.Position = new PointLatLng(latitude, longitude); // Initial coordinates
            gMapControl1.Zoom = 18;
            gMapControl1.MouseClick += GMapControl1_MouseClick;

            richTextBox1.Text = GetAddressFromLatLng(latitude, longitude, main.api_key);
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
    }
}
