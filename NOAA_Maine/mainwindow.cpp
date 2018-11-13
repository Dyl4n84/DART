#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <json/json.h>
#include <iostream>
#include <fstream>
#include <string>
#include <list>
#include <QStringListModel>
#include "graphdisplay.h"
#include "buoy.h"

std::list<Buoy> buoyList;

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_updateButton_released()
{
    /***** Run update code *****/
    // Open input file stream on json file
    /*
    std::ifstream insJSON;
    std::string jsonInputFile = "latest_obs.json";
    insJSON.open(jsonInputFile, std::ifstream::in);

    // Read in all json data
    insJSON.seekg (0, insJSON.end);
    int length = insJSON.tellg();
    insJSON.seekg (0, insJSON.beg);

    char * buffer = new char [length];
    insJSON.read (buffer,length);
    */

    //jsonObj = json_parse(*buffer, length);

    std::ifstream ins;
    ins.open("latest_obs.txt");

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
    ui->stationList->setModel(model);.


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

void MainWindow::on_stationList_indexesMoved(const QModelIndexList &indexes)
{
    ui->camView->setHtml();
}
