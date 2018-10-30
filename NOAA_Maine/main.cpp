#include <Python.h> // Attention: this MUST always be the first file included
#include "mainwindow.h"
#include <QApplication>
#include <QtWebKitWidgets>

const QString jsonGenerate = "scrape_NOAA_Data.py";

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

    // Load NOAA Station names into stationList
    FILE *fd = fopen("scrape_NOAA_Data.py", "r");
    PyRun_SimpleFileEx(fd, "scrape_NOAA_Data.py", 1);

    // Select most recently selected buoy

    // If buoy cam is available display it


    w.show();

    return a.exec();
}
