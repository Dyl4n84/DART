#include <iostream>
#include <vector>
#include <string>
#include "buoy.h"

using namespace std;

Buoy::Buoy(){
    bname = "NULL";
    HAP.clear();
    HAT.clear();
}

void Buoy::HAPinput(double in){
    HAP.push_back(in);
}

void Buoy::HATinput(double in){
    HAT.push_back(in);
}

void Buoy::HAPdisplay(){
    unsigned int size = HAP.size();
    for(unsigned int i =0; i < size; i++){
        cout << HAP[i]<< endl;
    }
}

void Buoy::HATdisplay(){
    unsigned int size = HAT.size();
    for(unsigned int i =0; i < size; i++){
        cout << HAT[i]<< endl;
    }
}
