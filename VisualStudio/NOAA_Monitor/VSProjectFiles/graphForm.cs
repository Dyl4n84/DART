/*Implementation for the graphForm class used in the LabRats Project.
*This class is for graphing data from NOAA Buoys off the coast of Maine.
*All functions are programmed in C# for implementation alongside VB.NET framework 4.6.1.
*
****************************
*
*Ohio University Athens, OH USA
*Written By: Dylan Rogers
*Last Updated: December 3rd, 2018
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

namespace NOAA_Monitor
{
  /**
  *This is the implementation of the graphing form class which inherits the MaterialForm class
  **/
    public partial class graphForm : MaterialForm
    {
        BuoyList Stations;
        Buoy tmpBuoy = new Buoy();

        string maineBuoys =
            "PSBM1 CFWM1 44027 ATGM1 44034" +
            "MDRM1 44037 44033 MISM1 44032" +
            "44005 CASM1 44007 44030 WEQM1 WEXM1 WELM1";
        /**
        *This is the constructor for the graphForm class
        * @param tmp is a temporary variable to transfer a BuoyList variable into the space of this class to be used for graphing
        **/
        public graphForm(BuoyList tmp)
        {
            Stations = new BuoyList(tmp);
            InitializeComponent();

            comboBox1.Items.Add("Wind Speed");
            comboBox1.Items.Add("Wind Direction");
            comboBox1.Items.Add("Dominant Wave");
            comboBox1.Items.Add("Average Wave Time");
            comboBox1.Items.Add("Sea Pressure");
            comboBox1.Items.Add("Air Temperature");
            comboBox1.Items.Add("Sea Temperature");
            comboBox1.Items.Add("Dew Temperature");
            comboBox1.Items.Add("Visibility");
            comboBox1.Items.Add("Tide Height");
        }
        /**
        *This is the function for when the graph button is clicked on the graphingForm
        **/
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            List<Buoy>.Enumerator data = Stations.List_of_buoys.GetEnumerator();
            int stepper = 0;
            int graphSelection;

            graphSelection = comboBox1.SelectedIndex;

            switch (graphSelection)
            {
                //Wind Speed Graph
                case 0:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.WindSpeed);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy. BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    windSpeedText();
                    break;

                //Wind Direction Graph
                case 1:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.WindDirection);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    windDirectionText();
                    break;

                //Dominant Wave Period Graph
                case 2:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.DominantWavePeriod);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    dominantWavePeriodText();
                    break;

                //Average Wave Period Graph
                case 3:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.AverageWave);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    averageWavePeriodText();
                    break;

                //Sea Pressure Graph
                case 4:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.SeaPressure);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    seaPressureText();
                    break;

                //Air Tempreature Graph
                case 5:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.AirTemperature);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    airTemperatureText();
                    break;

                //Sea Temperature Graph
                case 6:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.SeaTemperature);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    seaTemperatureText();
                    break;

                //Dew Temperature Graph
                case 7:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.DewTemperature);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    dewTemperatureText();
                    break;

                //Visibility Distance Graph
                case 8:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.Visibility);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    visibilityText();
                    break;

                //Tide Height Graph
                case 9:
                    while (data.MoveNext())
                    {
                        tmpBuoy = data.Current;
                        if (maineBuoys.Contains(tmpBuoy.BuoyName) && !String.IsNullOrEmpty(tmpBuoy.BuoyName))
                        {
                            chart1.Series[0].Points.AddY(tmpBuoy.Tide);
                            chart1.Series[0].Points[stepper].AxisLabel = tmpBuoy.BuoyName;
                            chart1.Series[0].Points[stepper].IsValueShownAsLabel = true;
                            stepper++;
                        }
                    }
                    tideHeightText();
                    break;

                default:
                    break;
            }

            //Displays the series value to the chart area
            chart1.Series[0].ChartArea = "ChartArea1";

            //Displays each values buoy name as a corresponding x-axis value
            chart1.ChartAreas[0].AxisX.Interval = 1;

            //Explination for the 0 values in the chart
            textBox1.AppendText(Environment.NewLine + Environment.NewLine
                +"*For all 0 values in the graph assume the buoy or land station did not take a reading");
        }

        /**
        *This prints out the text for the wind speed graph
        **/
        public void windSpeedText()
        {
            textBox1.Text = "This graph displays the wind speed recorded from the buoy sensors in meter per second. "
                + "These measurements were recorded over an average period of 8 minutes for buoys and 2 minutes for land stations.";
        }

        /**
        *This prints out the text for the wind direction graph
        **/
        public void windDirectionText()
        {
            textBox1.Text = "This graph displays the wind direction in degrees (°) clockwise from true North "
                + "during the same period used for the wind speed.";
        }

        /**
        *This prints out the text for the dominant wave period graph
        **/
        public void dominantWavePeriodText()
        {
            textBox1.Text = "This graph displays the dominant wave period in seconds. "
                + "This time is fro the period with the maximum wave energy.";
        }

        /**
        *This prints out the text for the average wave period graph
        **/
        public void averageWavePeriodText()
        {
            textBox1.Text = "This graph displays the average wave period in seconds. "
                + "This was recorded for all waves in a 20-minute period";
        }

        /**
        *This prints out the text for the sea pressure graph
        **/
        public void seaPressureText()
        {
            textBox1.Text = "This graph displays the sea pressure in hPa.";
        }

        /**
        *This prints out the text for the air temperature graph
        **/
        public void airTemperatureText()
        {
            textBox1.Text = "This graph displays the air temperature in °C";
        }

        /**
        *This prints out the text for the sea temperature graph
        **/
        public void seaTemperatureText()
        {
            textBox1.Text = "This graph displays the sea temperature in °C";
        }

        /**
        *This prints out the text for the dew temperature graph
        **/
        public void dewTemperatureText()
        {
            textBox1.Text = "This graph displays the dewpoint temperature in °C. "
               + "This was taken at the same height as the air temperature";
        }

        /**
        *This prints out the text for the visibility distance graph
        **/
        public void visibilityText()
        {
            textBox1.Text = "This graph displays the visibility distance in nautical miles";
        }

        /**
        *This prints out the text for the tide height graph
        **/
        public void tideHeightText()
        {
            textBox1.Text = "This graph displays the water level in feet above of below Mean Low Water";
        }
    }
}
