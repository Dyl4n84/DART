﻿/* Program Name: NOAA Monitor - Maine
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
 */
using System;
using MaterialSkin;
using MaterialSkin.Controls;
using IronPython.Hosting;
using System.Diagnostics;

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Run python webscraping script
            run_cmd(@"C:\Users\User\Code\LabRatsProject\VisualStudio\NOAA_Monitor\VSProjectFiles\bin\scrape_NOAA_buoy.py");

            // Add timestamp to buoy data file name
            timestampFile("tmp.txt");

            // Read in new Buoy data
            //readBuoyData();

            // Re-populate buoy data
        }

        private void run_cmd(string cmd)
        {
            
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = @"C:\Python27\python.exe";
            pythonInfo.Arguments = cmd;
            pythonInfo.CreateNoWindow = true;
            pythonInfo.UseShellExecute = false;
            pythonInfo.RedirectStandardOutput = true;

            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();


            
        }

        public void timestampFile(string _fileName)
        {
            string nowDateTime;

            nowDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            nowDateTime = nowDateTime.Replace('/', '_');
            nowDateTime = nowDateTime.Replace(':', '\0');
            _fileName += "_" + nowDateTime;
        }        

        public void readBuoyData(string _fileName)
        {
            // Call buoy input stream function using _fileName as input

        }
    }
}
