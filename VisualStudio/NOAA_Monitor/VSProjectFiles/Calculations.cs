using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculations
{
    /**
    *Class for all of the calculations being used to find missing values from the buoy data
    **/
    public class calculations
    {
        /**
        *Function to change from farenheit to celcius
        *@param faren_temp is the farenheit temperature being converted to celcius
        *@return returns a double which is the celcius temperature converted from the given farenheit temperature
        **/
        public double farenheit_to_celcius(double faren_temp)
        {
            double cel_temp = (faren_temp - 32) * 5 / 9;
            return cel_temp;
        }

        /**
        *Function to change from celcius to farenheit
        *@param cel_temp is the celcius temperature being converted to farenheit
        *@return returns a double which is the farenheit temperature converted from the given celcius temperature
        **/
        public double celcius_to_farenheit(double cel_temp)
        {
            double faren_temp = cel_temp * 9 / 5 - 32;
            return faren_temp;
        }

        /**
        *Function to calculate the vapor pressure
        *@param air_temp is the air temperature used to calculate the vapor pressure
        *@return returns the calculated vapor pressure from the given air temperature
        **/
        public double vapor_pressure(double air_temp)
        {
            double vap_pres = 6.11 * Math.Pow(10, ((7.5 * air_temp / (237.3 + air_temp))));
            return vap_pres;
        }

        /**
        *Function to calculate the saturated vapor pressureusing the dew point temperature
        *@param dew_point_temp is the dew point temperature used to calculate the saturated vapor pressure
        *@return returns the calculated saturated vapor pressure from the given dew point temperature
        **/
        public double saturated_vapor_pressure(double dew_point_temp)
        {
            double vap_pres = 6.11 * Math.Pow(10, ((7.5 * dew_point_temp / (237.3 + dew_point_temp))));
            return vap_pres;
        }

        /**
        *Function to caluculate the water temperature
        *@param air_temp is the air temperature used to caluclate water temperature
        *@param dew_point_temp is the dew point temperature used to calculate water temperature
        *@param air_pressure is the air pressure used to calculate the water temperature
        *@return returns the water temperature calculated from the given air temperature, dew point temperature, and air pressure
        **/
        public double water_temp(double air_temp, double dew_point_temp, double air_pressure)
        {
            double water_temperature = (air_temp + 273.15) / 0.621*(6.11 * Math.Pow(10, ((7.5 * dew_point_temp) / 237.7 * dew_point_temp))) / air_pressure;
            return water_temperature;
        }

        /**
        *Function to calculate the dew point
        *@param relative_humid is the relative humidity used in calculating the dew point
        *@param vap_pressure is the vapor pressure used in calculating dew point
        *@return returns the dew point calculated from the given relative_humid, and vap_pressure
        **/
         public double dew_point(double relative_humid, double vap_pressure)
        {
            double dew_point_temp = 237.3 * Math.Log((relative_humid * vap_pressure) / 611) / (7.5 * Math.Log(10) - Math.Log((relative_humid * vap_pressure) / 611));
            return dew_point_temp;
        }

        /**
        *Function to calculate the relative humidity
        *@param sat_vap_pressure is the saturated vapor pressure used in calculating the relative humidity
        *@param vap_pressure is the vapor pressure used in calculatin the relative humidity
        *@return returns the calculated relative humidity calculated from the given saturated vapor pressure, and vapor pressure
        **/
        public double relative_humidity(double sat_vap_pressure, double vap_pressure)
        {
            double rh = (vap_pressure / sat_vap_pressure) * 100;
            return rh;
        }
    }
}
