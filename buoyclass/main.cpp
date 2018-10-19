#include <iostream>
#include "buoy.h"
using namespace std;

int main()
{
    cout << "Hello World!" << endl;
    Buoy test;
    double input = 0;
    cout << "Please input HAP values: (type -1 to quit) " <<endl;
    do{
        cin >> input;
        if (input >= 0){test.HAPinput(input);}
    }while(input >= 0);
    cout << "Hourly Atmospheric Temperatures:" << endl;
    test.HAPdisplay();
    return 0;
}
