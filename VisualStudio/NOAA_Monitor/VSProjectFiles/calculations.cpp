#include "stdafx.h"
#include "calculations.h"
#include "math.h"

calculations::calculations()
{
}


calculations::~calculations()
{
}

double calculations::celcius_to_farenheit(double faren_temp) {
	double cel_temp = (faren_temp - 32) * 5 / 9;
	return cel_temp;
}

double calculations::farenheit_to_celcius(double cel_temp) {
	double faren_temp = cel_temp * 9 / 5 - 32;
	return cel_temp;
}

double calculations::vapor_pressure(double air_temp) {
	double vap_pres = 6.11 * pow(10, ((7.5*air_temp / (237.3 + air_temp))));
	return vap_pres;
}

double calculations::saturated_vapor_pressure(double dew_point_temp) {
	double vap_pres = 6.11 * pow(10, ((7.5*dew_point_temp / (237.3 + dew_point_temp))));
	return vap_pres;
}

double calculations::water_temp(double air_temp, double dew_point_temp, double air_pressure) {
	double water_temperature = (air_temp + 273.15) / (1 - (379 / 1000)(6.11*pow(10, ((7.5*dew_point_temp) / 237.7*dew_point_temp))) / air_pressure);
	return water_temperature;
}

double calculations::dew_point(double relative_humid, double vap_pressure) {
	double dew_point_temp = 237.3*log((relative_humid*vap_pressure) / 611) / (7.5*log(10) - log((relative_humid* vap_pressure) / 611));
	return dew_point_temp;
}

double calculations::relative_humidity(double sat_vap_pressure, double vap_pressure) {
	double rh = (vap_pressure / sat_vap_pressure) * 100;
	return rh;
}