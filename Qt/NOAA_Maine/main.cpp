#include <Python.h> // Attention: this MUST always be the first file included
#include "mainwindow.h"
#include <QApplication>
#include <QtWebKitWidgets>

const char* JSONGENERATOR = "scrape_NOAA_Data.py";

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

    // Load NOAA Station names into stationList
    //  Py_SetProgramName((wchar_t*)argv[0]);
    //Py_Initialize();


    // Select most recently selected buoy

    // If buoy cam is available display it


    w.show();

    return a.exec();
}
