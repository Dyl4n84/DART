#include "mainwindow.h"
#include "graphwindow.h"
#include "ui_mainwindow.h"
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
    graphWindow *tst = new graphWindow;
    tst->show();

}

void MainWindow::on_pushButton_2_clicked()
{
    QLineSeries *series = new QLineSeries();
    series->append(1,2);
    series->append(2,4);
    series->append(3,9);
    series->append(4,16);

    QChart *chart = new QChart();
    chart->legend()->hide();
    chart->addSeries(series);
    chart->createDefaultAxes();
    chart->setTitle("Example Chart");

    QChartView *chartView = new QChartView(chart);
    chartView->setRenderHint(QPainter::Antialiasing);

    /*QMainWindow *window = new QMainWindow(this);
    window->setCentralWidget(chartView);
    window->resize(400, 300);
    window->show();*/
}
