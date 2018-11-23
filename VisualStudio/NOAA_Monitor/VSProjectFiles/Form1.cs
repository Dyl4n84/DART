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
using MaterialSkin;
using MaterialSkin.Controls;
using MahApps.Metro.Controls;

namespace NOAA_Monitor
{
    public partial class MainWindow : MaterialForm
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.LightBlue900,
                Primary.Blue500, Accent.Cyan700,
                TextShade.WHITE
            );

            // Initialize weather map with Maine Coast coordinates: 43.952695, -68.672238


            // Pull in station data


            // Display station data


            // Display station picture


        }


        
    }
}
