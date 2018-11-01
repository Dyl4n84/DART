#include <iostream>
#include <fstream>
#include <vector>
#include "buoy.h"
using namespace std;

int main()
{
    ifstream fin;
    vector<Buoy> blist;
    Buoy temp;
    string skip;
    fin.open("test.txt");
    if(!fin.fail()){
        getline(fin, skip); //skips the first two lines of the file
        getline(fin, skip); //^
        while(!fin.eof()){
            temp.input(fin);
            blist.push_back(temp);
        }
        blist[4].display(); //diplays a buoy
        fin.close();
        }
     else{ cout << "file not found" << endl;}
}
