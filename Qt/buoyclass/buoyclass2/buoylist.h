#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "buoy.h"
#ifndef BUOYLIST_H
#define BUOYLIST_H
using namespace std;

class Buoylist
{
public:
    Buoylist();
    void load(std::istream& ins);
    void display(int index);
    void search(string target);
private:
    vector<Buoy> blist;
};

#endif // BUOYLIST_H
