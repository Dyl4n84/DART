#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <json/json.h>
#include <iostream>
#include <fstream>
#include <string>

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
    std::ifstream insJSON;
    std::string jsonInputFile = "latest_obs.json";
    insJSON.open(jsonInputFile, std::ifstream::in);

    // Read in all json data
    insJSON.seekg (0, insJSON.end);
    int length = insJSON.tellg();
    insJSON.seekg (0, insJSON.beg);

     char * buffer = new char [length];
     insJSON.read (buffer,length);

     jsonObj = json_parse(*buffer, length);


}

void MainWindow::on_calcButton_released()
{
    // Run calculations code

}

void MainWindow::on_graphButton_released()
{
    // Run graphing code

}

void MainWindow::on_mapButton_released()
{
    // Run mapping code

}

void MainWindow::on_saveButton_released()
{
    // Run data archiving code

    // Close the form
    this->close();
}

void MainWindow::on_closeButton_released()
{
    // Close the form
    this->close();
}
