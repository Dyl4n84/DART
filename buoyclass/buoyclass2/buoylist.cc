#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "buoylist.h"
#include "buoy.h"


Buoylist::Buoylist()
{
    //
}

void Buoylist::load(std::istream& ins){
    Buoy temp;
    string skip;
        getline(ins, skip); //skips the first two lines of the file
        getline(ins, skip); //^
        while(!ins.eof()){
            temp.input(ins);
            blist.push_back(temp);
        }
}

void Buoylist::display(int index){
    blist[index].display();
}

void Buoylist::search(string target){
    for(int i =0; i < blist.size(); i++){
        if (target == blist[i].getbname()){
            display(i);
            return;
        }
    }
    cout << "Not found" << endl;
    return;
}
