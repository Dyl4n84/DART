#pragma once
class calculations
{
public:
	calculations();
	~calculations();
	double celcius_to_farenheit(double faren_temp);
	double farenheit_to_celcius(double cel_temp);
	double vapor_pressure(double air_temp);
	double saturated_vapor_pressure(double dew_point_temp);
	double water_temp(double air_temp, double dew_point_temp, double air_pressure);
	double dew_point(double relative_humid, double vap_pressure);
	double relative_humidity(double sat_vap_pressure, double vap_pressure);
	double cel_temp;
	double faren_temp;
	double air_temp;
	double dew_point_temp;
	double relative_humid;
	double vap_pressure;
	double sat_vap_pressure;
};

