/* Program Name: NOAA Monitor - Maine
 * Written By: Jack Mullen, Prachetas Deshpande, Dylan Rogers, Joshua Wright
 * Description: ...
 * 
 ************************************************
 * 
 * Last Editted: 11.22.2018 @ 2:46PM
 * 
 * TO DO: Josh
 * Implement OpenWeatherMap into WebView
 * Pull in buoy station names
 * Set stationList datat source to station names 
 * Map buttons to appropriate class functions
 * Set Map Mode buttons to change map overlay
 * Display station pictures on stationList click event
 * Update station data - set limit for every 8 hours
 * Display station data to user
 * Set UI Theme to material design
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOAA_Monitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initialize weather map with Maine Coast coordinates: 43.952695, -68.672238
            

            // Pull in station data

            // Display station data

            // Display station picture
        }

        private void mapBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
