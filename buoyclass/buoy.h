#include <iostream>
#include <string>
#include <vector>
#ifndef BUOY_H
#define BUOY_H

using namespace std;

class Buoy{
public:
    Buoy();
    void HAPinput(double in);
    void HATinput(double in);
    void HAPdisplay();
    void HATdisplay();
private:
    string bname;
    vector<double> HAP;
    vector<double> HAT;
};

#endif // BUOY_H
