using System;

namespace NOAA_Monitor
{
    public class Buoy
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


        public Buoy()
        {
            BuoyName = null;
            Latitude = 100;
            Longitutde = 180;
            Date = null;
            WindSpeed = 100;
            WindDirection = 400;
            GustSpeed = 0;
            WaveHeight = 0;
            DominantWavePeriod = 0;
            AverageWave = 0;
            WaveDirection = 400;
            SeaPressure = 0;
            PressureChange = 0;
            AirTemperature = 100;
            SeaTemperature = 100;
            DewTemperature = 100;
            Visibility = -1;
            Tide = 100;
        }

        public Buoy(Buoy old)
        {
            if (Date != old.Date)
            {
                BuoyName = old.BuoyName;
                Latitude = old.Latitude;
                Longitutde = old.Longitutde;
                Date = old.Date;
                WindSpeed = old.WindSpeed;
                WindDirection = old.WindDirection;
                GustSpeed = old.GustSpeed;
                WaveHeight = old.WaveHeight;
                DominantWavePeriod = old.DominantWavePeriod;
                AverageWave = old.AverageWave;
                WaveDirection = old.WaveDirection;
                SeaPressure = old.SeaPressure;
                PressureChange = old.PressureChange;
                AirTemperature = old.AirTemperature;
                SeaTemperature = old.SeaTemperature;
                DewTemperature = old.DewTemperature;
                Visibility = old.Visibility;
                Tide = old.Tide;
            }
        }

        public void DisplayAllData()
        {
            Console.Write(BuoyName);
            Console.Write(" ");
            Console.Write(Longitutde);
            Console.Write(" ");
            Console.Write(Latitude);
            Console.Write(" ");
            Console.Write(Date);
            Console.Write(" ");
            Console.Write(WindSpeed);
            Console.Write(" ");
            Console.Write(WindDirection);
            Console.Write(" ");
            Console.Write(GustSpeed);
            Console.Write(" ");
            Console.Write(WaveHeight);
            Console.Write(" ");
            Console.Write(DominantWavePeriod);
            Console.Write(" ");
            Console.Write(AverageWave);
            Console.Write(" ");
            Console.Write(WaveDirection);
            Console.Write(" ");
            Console.Write(SeaPressure);
            Console.Write(" ");
            Console.Write(PressureChange);
            Console.Write(" ");
            Console.Write(AirTemperature);
            Console.Write(" ");
            Console.Write(SeaTemperature);
            Console.Write(" ");
            Console.Write(DewTemperature);
            Console.Write(" ");
            Console.Write(Visibility);
            Console.Write(" ");
            Console.Write(Tide);
            Console.Write("\n");
        }

    }

}