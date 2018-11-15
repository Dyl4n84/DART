#include "graphwindow.h"
#include "ui_graphwindow.h"

graphWindow::graphWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::graphWindow)
{
    ui->setupUi(this);
    /*ui->centralwidget = new QWidget(this);
    this->setCentralWidget(ui->centralwidget);

    QLineSeries *series = new QLineSeries;
    series->append(1,2);
    series->append(2,4);
    series->append(3,9);

    chart = new QChart;
    chart->addSeries(series);
    chart->legend()->hide();
    chart->setTitle("Test");

    chartView = new QChartView(chart);
    gridLayout = new QGridLayout(ui->centralwidget);
    gridLayout->addWidget(chartView,0,0);*/
}

graphWindow::~graphWindow()
{
    delete ui;
}
