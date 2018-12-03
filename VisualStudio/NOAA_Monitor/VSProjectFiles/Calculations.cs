using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculations
{
    public class calculations
    {
        public double celcius_to_farenheit(double faren_temp)
        {
            double cel_temp = (faren_temp - 32) * 5 / 9;
            return cel_temp;
        }

        public double farenheit_to_celcius(double cel_temp)
        {
            double faren_temp = cel_temp * 9 / 5 - 32;
            return cel_temp;
        }

        public double vapor_pressure(double air_temp)
        {
            double vap_pres = 6.11 * Math.Pow(10, ((7.5 * air_temp / (237.3 + air_temp))));
            return vap_pres;
        }

        public double saturated_vapor_pressure(double dew_point_temp)
        {
            double vap_pres = 6.11 * Math.Pow(10, ((7.5 * dew_point_temp / (237.3 + dew_point_temp))));
            return vap_pres;
        }

        public double water_temp(double air_temp, double dew_point_temp, double air_pressure)
        {
            double water_temperature = (air_temp + 273.15) / 0.621*(6.11 * Math.Pow(10, ((7.5 * dew_point_temp) / 237.7 * dew_point_temp))) / air_pressure;
            return water_temperature;
        }

         public double dew_point(double relative_humid, double vap_pressure)
        {
            double dew_point_temp = 237.3 * Math.Log((relative_humid * vap_pressure) / 611) / (7.5 * Math.Log(10) - Math.Log((relative_humid * vap_pressure) / 611));
            return dew_point_temp;
        }

        public double relative_humidity(double sat_vap_pressure, double vap_pressure)
        {
            double rh = (vap_pressure / sat_vap_pressure) * 100;
            return rh;
        }
    }
}

