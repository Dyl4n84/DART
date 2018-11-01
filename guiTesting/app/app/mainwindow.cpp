#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "graphdisplay.h"
#include "graph.h"
#include <QComboBox>
#include <QStringList>
#include <QLabel>
#include <QDialog>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    QStringList items_list;
    items_list << "No Selection..." << "Bar Graph" << "Line Graph";

    ui->comboBox->addItems(items_list);

}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pushButton_clicked()
{

    if(ui->comboBox->currentText() == "Bar Graph"){
        ui->label->setText("Bar");
    }
    else{
        ui->label->setText("Line");
    }

    tst = new graphDisplay();

    tst->show();
}
