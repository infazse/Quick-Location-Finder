using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Api.Maps.Service.Geocoding;
using Google.Api.Maps.Service.StaticMaps;
using Google.Api.Maps.Service;

namespace Quick_Location_Finder
{

    public partial class frmMainWindow : Form
    {
        GeocodingResult currentSelectedLocation;

        private void updateMap(){
            var result = (GeocodingResult)currentSelectedLocation;
            fullAddress.Text = result.FormattedAddress;

            var location = result.Geometry.Location;
            var map = new StaticMap();
            map.Center = location.Latitude.ToString() + "," + location.Longitude.ToString();
            txtLatitude.Text = location.Latitude.ToString();
            txtLongtitude.Text = location.Longitude.ToString(); 
            map.Zoom = (zoomLevels.SelectedItem == null) ? "10" : zoomLevels.Text.ToString(); 
            map.Markers = map.Center; map.Size = "1000" + "x" + "485";
            map.MapType = (mapTypeColombo.SelectedItem == null) ? "roadmap" : mapTypeColombo.Text.ToString(); 
            map.Sensor = "false";
            String urlToMap = map.ToUri().AbsoluteUri.ToString(); 
           webBrowser1.Navigate(urlToMap);
        
        
        
        }

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var request = new GeocodingRequest();
            request.Address = textLocation.Text;
            request.Sensor = "false";

            var response = GeocodingService.GetResponse(request);
            if (response.Status == ServiceResponseStatus.Ok) {
                currentSelectedLocation = response.Results.First();
            
            }
            updateMap();

        }
    }
}
