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
using System.Speech.Recognition;
using System.Speech.Recognition.SrgsGrammar;

namespace Quick_Location_Finder
{

    public partial class frmMainWindow : Form
    {
        GeocodingResult currentSelectedLocation;
        public static String list;
        
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
            SpeechRecognizer recognizer = new SpeechRecognizer();
            Choices colors = new Choices();
            colors.Add(new string[] { "London", "Colombo", "Kandy" });

            //// Create a GrammarBuilder object and append the Choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);

            //// Create the Grammar instance and load it into the speech recognition engine.
            Grammar g = new Grammar(gb);
            recognizer.LoadGrammar(g);

            recognizer.SpeechRecognized +=
             new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //var request = new GeocodingRequest();
            //SpeechRecognizer recognizer = new SpeechRecognizer();
            //recognizer.SpeechRecognized +=
            // new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
        

            //request.Address = textLocation.Text;
            //request.Address=
            

            //var response = GeocodingService.GetResponse(request);
            //if (response.Status == ServiceResponseStatus.Ok) {
            //    currentSelectedLocation = response.Results.First();
            
            //}
            //updateMap();

            var request = new GeocodingRequest();
            //request.Address = list
            
            //foreach (String lists in list)
            //{
            //    request.Address = lists;
            //    //textLocation.AppendText(" " + lists);
            //}
            request.Address = textLocation.Text;
            request.Sensor = "false";

            var response = GeocodingService.GetResponse(request);
            if (response.Status == ServiceResponseStatus.Ok)
            {
                currentSelectedLocation = response.Results.First();

            }
            updateMap();

        }
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //richTextBox1.AppendText("Speech recognized: " + e.Result.Text.ToString());
            //var request = new GeocodingRequest();
            //request.Address = e.Result.Text.ToString();
            //request.Sensor = "false";

            //var response = GeocodingService.GetResponse(request);
            //if (response.Status == ServiceResponseStatus.Ok)
            //{
            //    currentSelectedLocation = response.Results.First();

            //}
            //updateMap();
            //textLocation.AppendText(" " + e.Result.Text.ToString());

            textLocation.AppendText(" " + e.Result.Text.ToString());
            list = e.Result.Text.ToString();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
