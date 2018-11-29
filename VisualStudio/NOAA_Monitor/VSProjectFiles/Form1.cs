/* Program Name: NOAA Monitor - Maine
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
            run_cmd(pathToSolution + @"\scrape_NOAA_buoy.py");

            // Add timestamp to buoy data file name
            string updatedDataFile = timestampFile(pathToSolution + @"\bin\Debug\tmp.txt");

            // Read in new Buoy data
            Stations = readBuoyData(updatedDataFile);

            // Re-populate buoy data
            string stationNames =
            "PSBM1 CFWM1 44027 ATGM1 44034" +
            "MDRM1 44037 44033 MISM1 44032" +
            "44005 CASM1 44007 44030 WEQM1 WEXM1 WELM1";

            List<Buoy>.Enumerator stationIter = Stations.blist.GetEnumerator();
            Buoy tmpStation = new Buoy();

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Station List";
            this.stationList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            while (stationIter.MoveNext())
            {
                tmpStation = stationIter.Current;
                if (stationNames.Contains(tmpStation.getbname()) && !String.IsNullOrEmpty(tmpStation.getbname()))
                {
                    ListViewItem stationNameItems = new ListViewItem(tmpStation.getbname());
                    stationList.Items.Add(stationNameItems);
                }
            }
            stationList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Initialize weather map with Maine Coast coordinates: 43.952695, -68.672238
            setupMapView("43.952695", "-68.672238");
        }

        public void setupMapView(string latitude, string longitude)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string pathToSolution = @"C:\Users\User\Code\LabRatsProject\VisualStudio\NOAA_Monitor\VSProjectFiles";

            // Run python webscraping script
            run_cmd(pathToSolution + @"\scrape_NOAA_buoy.py");

            // Add timestamp to buoy data file name
            string updatedDataFile = timestampFile(pathToSolution + @"\bin\Debug\tmp.txt");

            // Read in new Buoy data
            Stations = readBuoyData(updatedDataFile);

            // Re-populate buoy data
            string stationNames =
            "PSBM1 CFWM1 44027 ATGM1 44034 " +
            "MDRM1 44037 44033 MISM1 44032 " +
            "44005 CASM1 44007 44030 WEQM1 WEXM1 WELM1";

            List<Buoy>.Enumerator stationIter = Stations.blist.GetEnumerator();
            Buoy tmpStation = new Buoy();

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Station List";
            this.stationList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            while (stationIter.MoveNext())
            {
                tmpStation = stationIter.Current;
                if (stationNames.Contains(tmpStation.getbname()) && !String.IsNullOrEmpty(tmpStation.getbname()))
                {
                    ListViewItem stationNameItems = new ListViewItem(tmpStation.getbname());
                    stationList.Items.Add(stationNameItems);
                }
            }

            stationList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void run_cmd(string cmd)
        {
            
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            // Process python;
            pythonInfo.FileName = @"py";
            pythonInfo.Arguments = cmd;
            pythonInfo.CreateNoWindow = true;
            pythonInfo.UseShellExecute = false;
            pythonInfo.RedirectStandardOutput = false;
            pythonInfo.RedirectStandardError = false;
            Process.Start(pythonInfo);
        }

        public string timestampFile(string _fileName)
        {
            string nowDateTime;

            nowDateTime = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm");
            updateLabel.Text = "Last Updated: " + nowDateTime + " GMT";
            nowDateTime = nowDateTime.Replace('/', '_');
            nowDateTime = nowDateTime.Replace(' ', '_');
            nowDateTime = nowDateTime.Replace(':', '_');
            string newFileName = "latest_obs-" + nowDateTime + ".txt";
            try
            {
                System.IO.File.Move(_fileName, newFileName);
            }
            catch
            {
                return newFileName;
            }

            return newFileName;
        }        

        public BuoyList readBuoyData(string _fileName)
        {
            // Call buoy input stream function using _fileName as input
            BuoyList tmpBuoys = new BuoyList();
            tmpBuoys.load(_fileName);

            return tmpBuoys;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            graphForm graphUI = new graphForm();
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
            for (int i = 0; i < Stations.blist.Count; ++i)
            {
                if (Stations.blist[i].getbname() == selectedStationName)
                {
                    // Get Buoy from BuoyList
                    Buoy tmp = new Buoy();
                    tmp = Stations.blist[i];

                    // Write Buoy data to labels
                    label1.Text = "Name: " + tmp.getbname();
                    label2.Text = "Lat/Lon:" + tmp.getlatlon();
                    label3.Text = "Wind Speed:" + tmp.getwindspeed();
                    label4.Text = "Gust:" + tmp.getgustspeed();
                    label5.Text = "Wave Height:" + tmp.getwaveheight();
                    label6.Text = "Wave Direction:" + tmp.getwavedir();
                    label7.Text = "Wave Period:" + tmp.getdomwave();
                    label8.Text = "Mean Tide Level:" + tmp.gettide();
                    label9.Text = "Sea level Pressure:" + tmp.getseapress();
                    label10.Text = "Pressure Change:" + tmp.getpressten(); 
                    label11.Text = "Sea Temp.:" + tmp.getseatemp();
                    label12.Text = "Air Temp.:" + tmp.getairtemp();
                    label13.Text = "Dew Point:" + tmp.getdewtemp();
                    label14.Text = "Visibility:" + tmp.getvis();
                    
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
    }
}
