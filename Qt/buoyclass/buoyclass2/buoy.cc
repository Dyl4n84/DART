#include <iostream>
#include <string>
#include <fstream>
#include "buoy.h"

using namespace std;

Buoy::Buoy(){
    bname = "NULL";
    for(int i = 0; i < 2; i++){
        latlon[i] = "MM";
    }
    for(int j = 0; j < 5; j++){
        date[j] ="MM";
    }
    windspeed = "MM";
    winddir ="MM";
    gustspeed = "MM";
    waveheight ="MM";
    domwave = "MM";
    avewave ="MM";
    wavedir ="MM";
    seapress ="MM";
    pressten ="MM";
    seatemp ="MM";
    airtemp ="MM";
    dewtemp ="MM";
    vis ="MM";
    tide ="MM";
}

void Buoy::input(std::istream& ins){
    ins >> bname;
    ins >> latlon[0];
    ins >> latlon[1];
    ins >> date[0];
    ins >> date[1];
    ins >> date[2];
    ins >> date[3];
    ins >> date[4];
    ins >> windspeed;
    ins >> winddir;
    ins >> gustspeed;
    ins >> waveheight;
    ins >> domwave;
    ins >> avewave;
    ins >> wavedir;
    ins >> seapress;
    ins >> pressten;
    ins >> seatemp;
    ins >> airtemp;
    ins >> dewtemp;
    ins >> vis;
    ins >> tide;
}

void Buoy::display(){
    cout << bname << endl;
    cout << "Coordinates are (" << latlon[0] << "," << latlon[1] << ")" << endl;
    cout << "Date is " << date[1] << "-" << date[2] << "-" << date[0] << " at " << date[3] << ":" << date[4] << endl;
    cout << "Wind speed is " << windspeed << " with a direction of " << winddir << endl;
    cout << "Gust speed is " << gustspeed << endl;
    cout << "Wave Height is " << waveheight <<endl;
    cout << "Dominant wave is " << domwave <<endl;
    cout << "Average wave is " << avewave <<endl;
    cout << "Wave direction is " << wavedir <<endl;
    cout << "Sea pressure is " << seapress <<endl;
    cout << "Pressure tendency is " << pressten <<endl;
    cout << "Sea temperature is " << seatemp <<endl;
    cout << "Air temperature is " << airtemp <<endl;
    cout << "Dewpoint temperature is " << dewtemp <<endl;
    cout << "Visibility is " << vis <<endl;
    cout << "Tide is " << tide <<endl;
}

string Buoy::getbname(){
    return bname;
}

string Buoy::getlatlon(){
     string s = "(" + latlon [0] +"," + latlon[1]+")";
     return s;
 }

 string Buoy::getdate(){
     string s = date[1] + "-" +date[2] + "-"+ date[0] + " at " + date[3] + ":" + date[4];
     return s;
 }

 string Buoy::getwindspeed(){
     return windspeed;
 }

 string Buoy::getgustspeed(){
     return gustspeed;
 }

 string Buoy::getwaveheight(){
     return waveheight;
 }

 string Buoy::getdomwave(){
     return domwave;
 }

 string Buoy::getavewave(){
     return avewave;
 }

 string Buoy::getwavedir(){
     return wavedir;
 }

 string Buoy::getseapress(){
     return seapress;
 }

 string Buoy::getpressten(){
     return pressten;
 }

 string Buoy::getseatemp(){
     return seatemp;
 }

 string Buoy::getairtemp(){
     return airtemp;
 }

 string Buoy::getdewtemp(){
     return dewtemp;
 }

 string Buoy::getvis(){
     return vis;
 }

 string Buoy::gettide(){
     return tide;
 }
