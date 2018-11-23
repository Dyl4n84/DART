#include <iostream>
#include <fstream>
#include <vector>
#include "buoy.h"
#include "buoylist.h"
using namespace std;

int main()
{
    Buoylist test;
    ifstream fin;
    string target;
    fin.open("test.txt");
    if(!fin.fail()){
        test.load(fin);
        fin.close();
    }
    else{ cout << "file not found" << endl;}
    cout << "Search a buoy by name:" << endl;
    cin >> target;
    test.search(target);
}
