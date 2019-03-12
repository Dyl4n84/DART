using System;

namespace NOAA_Monitor
{
    public class Buoy
    {
        public DataValues DataSet = new DataValues();

        public Buoy()
        {
            DataSet.BuoyName = null;
            DataSet.Latitude = 100;
            DataSet.Longitutde = 180;
            DataSet.Date = null;
            DataSet.WindSpeed = 100;
            DataSet.WindDirection = 400;
            DataSet.GustSpeed = 0;
            DataSet.WaveHeight = 0;
            DataSet.DominantWavePeriod = 0;
            DataSet.AverageWave = 0;
            DataSet.WaveDirection = 400;
            DataSet.SeaPressure = 0;
            DataSet.PressureChange = 0;
            DataSet.AirTemperature = 100;
            DataSet.SeaTemperature = 100;
            DataSet.DewTemperature = 100;
            DataSet.Visibility = -1;
            DataSet.Tide = 100;
        }

        public Buoy(Buoy old)
        {
            if (DataSet.Date != old.DataSet.Date)
            {
                DataSet.BuoyName = old.DataSet.BuoyName;
                DataSet.Latitude = old.DataSet.Latitude;
                DataSet.Longitutde = old.DataSet.Longitutde;
                DataSet.Date = old.DataSet.Date;
                DataSet.WindSpeed = old.DataSet.WindSpeed;
                DataSet.WindDirection = old.DataSet.WindDirection;
                DataSet.GustSpeed = old.DataSet.GustSpeed;
                DataSet.WaveHeight = old.DataSet.WaveHeight;
                DataSet.DominantWavePeriod = old.DataSet.DominantWavePeriod;
                DataSet.AverageWave = old.DataSet.AverageWave;
                DataSet.WaveDirection = old.DataSet.WaveDirection;
                DataSet.SeaPressure = old.DataSet.SeaPressure;
                DataSet.PressureChange = old.DataSet.PressureChange;
                DataSet.AirTemperature = old.DataSet.AirTemperature;
                DataSet.SeaTemperature = old.DataSet.SeaTemperature;
                DataSet.DewTemperature = old.DataSet.DewTemperature;
                DataSet.Visibility = old.DataSet.Visibility;
                DataSet.Tide = old.DataSet.Tide;
            }
        }

        public void DisplayAll()
        {
            Console.Write(DataSet.BuoyName);
            Console.Write(" ");
            Console.Write(DataSet.Longitutde);
            Console.Write(" ");
            Console.Write(DataSet.Latitude);
            Console.Write(" ");
            Console.Write(DataSet.Date);
            Console.Write(" ");
            Console.Write(DataSet.WindSpeed);
            Console.Write(" ");
            Console.Write(DataSet.WindDirection);
            Console.Write(" ");
            Console.Write(DataSet.GustSpeed);
            Console.Write(" ");
            Console.Write(DataSet.WaveHeight);
            Console.Write(" ");
            Console.Write(DataSet.DominantWavePeriod);
            Console.Write(" ");
            Console.Write(DataSet.AverageWave);
            Console.Write(" ");
            Console.Write(DataSet.WaveDirection);
            Console.Write(" ");
            Console.Write(DataSet.SeaPressure);
            Console.Write(" ");
            Console.Write(DataSet.PressureChange);
            Console.Write(" ");
            Console.Write(DataSet.AirTemperature);
            Console.Write(" ");
            Console.Write(DataSet.SeaTemperature);
            Console.Write(" ");
            Console.Write(DataSet.DewTemperature);
            Console.Write(" ");
            Console.Write(DataSet.Visibility);
            Console.Write(" ");
            Console.Write(DataSet.Tide);
            Console.Write("\n");
        }

        public void DisplayAllData()
        {
            DisplayAll();
        }


    }


    public struct DataValues
    {
        public string BuoyName; /// The Buoy ID
        public double Latitude; /// The latitude coordinates of the buoy
        public double Longitutde; /// The longitude coordinates of the buoy
        public string Date; /// The date and time of that the data was taken
        public double WindSpeed; /// Wind speed in meters per second averaged over an eight-minute period for buoys and a two-minute period for land stations.
        public double WindDirection; /// The direction the wind is coming from in degrees clockwise from true N during the same period used for WSPD
        public double GustSpeed; /// Peak five or eight second gust speed in meters per second measured during the eight-minute or two-minute period.
        public double WaveHeight; /// Significant wave height in meters is calculated as the average of the highest one-third of all of the wave heights during the twenty-minute sampling period.
        public double DominantWavePeriod; /// Dominant wave period seconds is the period with the maximum wave energy.
        public double AverageWave; /// Average wave period seconds of all waves during the twenty-minute period.
        public double WaveDirection; /// The direction from which the waves at the dominant period or DPD are coming. The units are degrees from true North increasing clockwise with North as zero degrees and East as ninty degrees. 
        public double SeaPressure; /// Sea level pressure in hPa
        public double PressureChange; /// the direction plus or minus and the amount of pressure change in hPa for a three hour period ending at the time of observation
        public double AirTemperature; /// Air temperature in Celsius
        public double SeaTemperature; /// Sea surface temperature in Celsius
        public double DewTemperature; /// Dewpoint temperature taken at the same height as the air temperature measurement
        public double Visibility; /// Station visibility in nautical miles
        public double Tide; /// The water level in feet above or below Mean Lower Low Water


    }

}