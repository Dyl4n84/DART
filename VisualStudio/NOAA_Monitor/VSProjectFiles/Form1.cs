﻿/* Program Name: NOAA Monitor - Maine
 * Written By: Jack Mullen, Prachetas Deshpande, Dylan Rogers, Joshua Wright
 * Description: ...
 *
 ************************************************
 *
 * Last Editted: 11.28.2018
 *
 * TO DO: Josh
 * Pull in buoy station names
 * Set stationList data source to station name
 * Display station data to user
 * Implement OpenWeatherMap into WebView
 * Set Map Mode buttons to change map overlay
 * Display station pictures on stationList click event
 */

using System;
using MaterialSkin;
using MaterialSkin.Controls;
using IronPython.Hosting;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NOAA_Monitor
{
    public partial class MainWindow : MaterialForm
    {
        BuoyList Stations = new BuoyList();
        Events Event_Processes = new Events();

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

            /***** Trigger updateButton_click Event *****/
            string pathToSolution = @"C:\Users\User\Code\LabRatsProject\VisualStudio\NOAA_Monitor\VSProjectFiles";

            // Run python webscraping script
            Event_Processes.run_cmd(pathToSolution + @"\scrape_NOAA_buoy.py");

            // Add timestamp to buoy data file name
            string updatedDataFile = Event_Processes.timestampFile(pathToSolution + @"\bin\Debug\tmp.txt", this);

            // Read in new Buoy data
            Stations = readBuoyData(updatedDataFile);

            // Re-populate buoy data
            string stationNames =
            "PSBM1 CFWM1 44027 ATGM1 44034" +
            "MDRM1 44037 44033 MISM1 44032" +
            "44005 CASM1 44007 44030 WEQM1 WEXM1 WELM1";

            List<Buoy>.Enumerator stationIter = Stations.List_of_buoys.GetEnumerator();
            Buoy tmpStation = new Buoy();

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Station List";
            this.stationList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            while (stationIter.MoveNext())
            {
                tmpStation = stationIter.Current;
                if (stationNames.Contains(tmpStation.BuoyName) && !String.IsNullOrEmpty(tmpStation.BuoyName))
                {
                    ListViewItem stationNameItems = new ListViewItem(tmpStation.BuoyName);
                    stationList.Items.Add(stationNameItems);
                }
            }
            stationList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            string pathToSolution = @"C:\Users\User\Code\LabRatsProject\VisualStudio\NOAA_Monitor\VSProjectFiles";

            // Run python webscraping script
            Event_Processes.run_cmd(pathToSolution + @"\scrape_NOAA_buoy.py");

            // Add timestamp to buoy data file name
            string updatedDataFile = Event_Processes.timestampFile(pathToSolution + @"\bin\Debug\tmp.txt", this);

            // Read in new Buoy data
            Stations = readBuoyData(updatedDataFile);

            // Re-populate buoy data
            string stationNames =
            "PSBM1 CFWM1 44027 ATGM1 44034 " +
            "MDRM1 44037 44033 MISM1 44032 " +
            "44005 CASM1 44007 44030 WEQM1 WEXM1 WELM1";

            List<Buoy>.Enumerator stationIter = Stations.List_of_buoys.GetEnumerator();
            Buoy tmpStation = new Buoy();

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Station List";
            this.stationList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            while (stationIter.MoveNext())
            {
                tmpStation = stationIter.Current;
                if (stationNames.Contains(tmpStation.BuoyName) && !String.IsNullOrEmpty(tmpStation.BuoyName))
                {
                    ListViewItem stationNameItems = new ListViewItem(tmpStation.BuoyName);
                    stationList.Items.Add(stationNameItems);
                }
            }

            stationList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public BuoyList readBuoyData(string _fileName)
        {
            // Call buoy input stream function using _fileName as input
            BuoyList tmpBuoys = new BuoyList();
            tmpBuoys.Load(_fileName);

            return tmpBuoys;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            graphForm graphUI = new graphForm(Stations);
            graphUI.ShowDialog();
        }

        private void stationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStationName = "XXXXX";
            ListView.SelectedListViewItemCollection selectedStations = stationList.SelectedItems;
            if (selectedStations.Count > 0)
            {
                selectedStationName = selectedStations[0].Text;
            }

            /***** Display buoy data according to station name *****/
            // Get selected station name
            for (int i = 0; i < Stations.List_of_buoys.Count; ++i)
            {
                if (Stations.List_of_buoys[i].BuoyName == selectedStationName)
                {
                    // Get Buoy from BuoyList
                    Buoy tmp = new Buoy();
                    tmp = Stations.List_of_buoys[i];

                    // Write Buoy data to labels
                    label1.Text = "Name: " + tmp.BuoyName;
                    label2.Text = "Lat/Lon:" + tmp.Latitude + " " + tmp.Longitutde;
                    label3.Text = "Wind Speed:" + tmp.WindSpeed;
                    label4.Text = "Gust:" + tmp.GustSpeed;
                    label5.Text = "Wave Height:" + tmp.WaveHeight;
                    label6.Text = "Wave Direction:" + tmp.WaveDirection;
                    label7.Text = "Wave Period:" + tmp.DominantWavePeriod;
                    label8.Text = "Mean Tide Level:" + tmp.Tide;
                    label9.Text = "Sea level Pressure:" + tmp.SeaPressure;
                    label10.Text = "Pressure Change:" + tmp.PressureChange;
                    label11.Text = "Sea Temp.:" + tmp.SeaTemperature;
                    label12.Text = "Air Temp.:" + tmp.AirTemperature;
                    label13.Text = "Dew Point:" + tmp.DewTemperature;
                    label14.Text = "Visibility:" + tmp.Visibility;

                }
            }

            changeStationPicture(selectedStationName);
        }

        public void changeStationPicture(string _stationName)
        {

            stationPicture.ImageLocation =
                @"C:\Users\User\Code\LabRatsProject\VisualStudio\NOAA_Monitor\VSProjectFiles\StationPictures\"
                + _stationName.ToLower()
                + ".jpg";
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            Uri googleMapLink =
                new Uri("https://www.google.com/maps/place/Monhegan,+ME/@43.8064599,-69.3245106,8.8z/data=!4m13!1m7!3m6!1s0x0:0x0!2zNDPCsDU3JzA5LjciTiA2OMKwNDAnMjAuMSJX!3b1!8m2!3d43.952695!4d-68.672238!3m4!1s0x4cadabf89b385c83:0xefcad36f202a94cd!8m2!3d43.7621682!4d-69.3202972");

            mapBrowser.Url = googleMapLink;
        }

        private void esriButton_Click(object sender, EventArgs e)
        {
            Uri googleSatLink =
                new Uri("https://www.google.com/maps/place/Monhegan,+ME/@43.8064599,-69.3245106,172059m/data=!3m1!1e3!4m13!1m7!3m6!1s0x0:0x0!2zNDPCsDU3JzA5LjciTiA2OMKwNDAnMjAuMSJX!3b1!8m2!3d43.952695!4d-68.672238!3m4!1s0x4cadabf89b385c83:0xefcad36f202a94cd!8m2!3d43.7621682!4d-69.3202972");

            mapBrowser.Url = googleSatLink;
        }
    }
}