#ifndef BUOY_H
#define BUOY_H

//#include <iostream>
#include <string>
#include <fstream>
using namespace std;

class Buoy{
public:
    Buoy(); //constructor
    void input(std::istream& ins);//inputs data
    void display(); //displays Pressure vector
private:
    string bname; //name of buoy
    string latlon[2]; //latitude and longitude
    string date[5]; //
    string windspeed;
    string winddir;
    string gustspeed;
    string waveheight;
    string domwave;
    string avewave;
    string wavedir;
    string seapress;
    string pressten;
    string airtemp;
    string seatemp;
    string dewtemp;
    string vis;
    string tide;
};

#endif // BUOY_H
