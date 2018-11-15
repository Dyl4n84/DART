#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QStringListModel>
#include <QPixmap>
#include <QBitmap>
#include <iostream>
#include <fstream>
#include <string>
#include <list>
#include <ctime>
#include <ratio>
#include <chrono>
#include <ctime>
#include <json/json.h>
#include <cstdio>
#include "graphdisplay.h"
#include "buoy.h"

std::list<Buoy> buoyList;

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    /***** Run update code *****/
    // Run python script
    std::string filename = "scrape_NOAA_buoy.py";
    std::string command = "python3 ";
    command += filename;
    system(command.c_str());
    std::chrono::system_clock::time_point readTime = std::chrono::system_clock::now(); // Current Date & Time
    std::time_t readTime_t = std::chrono::system_clock::to_time_t(readTime); // Convert to time_t
    std::string readTime_string = ctime(&readTime_t);

    // Write date and time to label on form
    readTime_string.erase (std::remove(readTime_string.begin(), readTime_string.end(), '\n'), readTime_string.end());
    ui->datetimeLabel->setText(QString::fromStdString("Last Update: " + readTime_string + " EST"));
    \
    // Append the date and time to the latest_obs text just pulled
    std::replace( readTime_string.begin(), readTime_string.end(), ' ', '_');
    std::string fileNameWrite = "latest_obs_" + readTime_string + ".txt";
    const char *fileName_char = fileNameWrite.c_str();
    std::rename("tmp.txt", fileName_char);

    // Open the latest_obs_file to read in new data
    std::ifstream ins;
    ins.open(fileNameWrite);

    Buoy b1;
    Buoy b2;
    Buoy tmpBuoy;

    b1.input(ins);
    b2.input(ins);

    QStringListModel *model;

    // Create model
    model = new QStringListModel(this);

    QStringList stringList;

    // teststream to read from file
    while(!ins.eof())
    {
        tmpBuoy.input(ins);

        // Only add buoys to list that we a tracking (Coast of Maine)
        if (tmpBuoy.buoyname() == "PSBM1" || tmpBuoy.buoyname() == "CFWM1" || tmpBuoy.buoyname() ==  "44027" ||
                tmpBuoy.buoyname() ==  "ATGM1" || tmpBuoy.buoyname() ==  "44034" || tmpBuoy.buoyname() == "MDRM1" ||
                tmpBuoy.buoyname() ==  "44037" || tmpBuoy.buoyname() ==  "44033" || tmpBuoy.buoyname() ==  "MISM1" ||
                tmpBuoy.buoyname() ==  "44032" || tmpBuoy.buoyname() == "44005" || tmpBuoy.buoyname() ==  "CASM1" ||
                tmpBuoy.buoyname() ==  "44007" || tmpBuoy.buoyname() ==  "44030" || tmpBuoy.buoyname() ==  "WEQM1" ||
                tmpBuoy.buoyname() == "WEXM1" || tmpBuoy.buoyname() ==  "WELM1")
        {
            buoyList.push_front(tmpBuoy);
            const QString buoyName = QString::fromStdString(tmpBuoy.buoyname());
            stringList.append(buoyName); // populate the stringlist
        }
    }

    // Populate the model
    model->setStringList(stringList);

    // Glue model and view together
    ui->stationList->setModel(model);

    // Load map of northeast usa buoys



}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_updateButton_released()
{
    /***** Run update code *****/
    // Run python script
    std::string filename = "scrape_NOAA_buoy.py";
    std::string command = "python3 ";
    command += filename;
    system(command.c_str());
    std::chrono::system_clock::time_point readTime = std::chrono::system_clock::now(); // Current Date & Time
    std::time_t readTime_t = std::chrono::system_clock::to_time_t(readTime); // Convert to time_t
    std::string readTime_string = ctime(&readTime_t);

    // Write date and time to label on form
    readTime_string.erase (std::remove(readTime_string.begin(), readTime_string.end(), '\n'), readTime_string.end());
    ui->datetimeLabel->setText(QString::fromStdString("Last Update: " + readTime_string + " EST"));
    \
    // Append the date and time to the latest_obs text just pulled
    std::replace( readTime_string.begin(), readTime_string.end(), ' ', '_');
    std::string fileNameWrite = "latest_obs_" + readTime_string + ".txt";
    const char *fileName_char = fileNameWrite.c_str();
    std::rename("tmp.txt", fileName_char);

    // Open the latest_obs_file to read in new data
    std::ifstream ins;
    ins.open(fileNameWrite);

    /***** Load buoy data *****/
    Buoy b1;
    Buoy b2;
    Buoy tmpBuoy;

    b1.input(ins);
    b2.input(ins);

    QStringListModel *model;

    // Create model
    model = new QStringListModel(this);

    QStringList stringList;

    // teststream to read from file
    while(!ins.eof())
    {
        tmpBuoy.input(ins);

        // Only add buoys to list that we a tracking (Coast of Maine)
        if (tmpBuoy.buoyname() == "PSBM1" || tmpBuoy.buoyname() == "CFWM1" || tmpBuoy.buoyname() ==  "44027" ||
                tmpBuoy.buoyname() ==  "ATGM1" || tmpBuoy.buoyname() ==  "44034" || tmpBuoy.buoyname() == "MDRM1" ||
                tmpBuoy.buoyname() ==  "44037" || tmpBuoy.buoyname() ==  "44033" || tmpBuoy.buoyname() ==  "MISM1" ||
                tmpBuoy.buoyname() ==  "44032" || tmpBuoy.buoyname() == "44005" || tmpBuoy.buoyname() ==  "CASM1" ||
                tmpBuoy.buoyname() ==  "44007" || tmpBuoy.buoyname() ==  "44030" || tmpBuoy.buoyname() ==  "WEQM1" ||
                tmpBuoy.buoyname() == "WEXM1" || tmpBuoy.buoyname() ==  "WELM1")
        {
            buoyList.push_front(tmpBuoy);
            const QString buoyName = QString::fromStdString(tmpBuoy.buoyname());
            stringList.append(buoyName); // populate the stringlist
        }
    }

    // Populate the model
    model->setStringList(stringList);

    // Glue model and view together
    ui->stationList->setModel(model);

    // Load selected buoy's data to data display


}

void MainWindow::on_calcButton_released()
{
    // Run calculations code

}

void MainWindow::on_graphButton_released()
{
    // Run graphing code
    graphDisplay* graphForm = new graphDisplay();
	graphForm->show();	

}

void MainWindow::on_mapButton_released()
{
    // Run mapping code

}

void MainWindow::on_saveButton_released()
{
    // Run data archiving code
    Buoy b1 = Buoy();

    // Close the form
    this->close();
}

void MainWindow::on_closeButton_released()
{
    // Close the form
    this->close();
}

void MainWindow::on_stationList_pressed(const QModelIndex &index)
{
    // Grab station name from stationList
    const QModelIndex listIndex = ui->stationList->selectionModel()->currentIndex();
    const QVariant itemData = ui->stationList->model()->data(listIndex);
    const QString stationName = itemData.toString().toLower();

    const QString pathToImage = "StationPictures/" + stationName.toLower() + ".jpg";
    QPixmap pixmap_StationImage(pathToImage);
    ui->buoyPicture->setPixmap(pixmap_StationImage);
    ui->buoyPicture->setMask(pixmap_StationImage.mask());

    ui->buoyPicture->show();

}
