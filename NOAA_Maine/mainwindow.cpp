#include "mainwindow.h"
#include "ui_mainwindow.h"

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
    // Run update code
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
}

void MainWindow::on_closeButton_released()
{
    // Close the form
}
