#include "graph.h"
#include "mainwindow.h"
#include <QtWidgets/QApplication>
#include <QtWidgets/QMainWindow>
#include <QtCharts/QChartView>
#include <QtCharts/QBarSeries>
#include <QtCharts/QLineSeries>
#include <QtCharts/QBarSet>
#include <QtCharts/QLegend>
#include <QtCharts/QBarCategoryAxis>
#include <QtCharts/QValueAxis>

QT_CHARTS_USE_NAMESPACE

graph::graph(){
    /*for(int x = 0; x < 10; x++)
        data->append(x);
    name = "Test Buoy";*/
}

graph::~graph(){

}

QChartView* graph::line_graph(){
    //These are here for the use of a new application window
    /*char *argv[]= {"Line Graph"};
    int argc = sizeof(argv) / sizeof (char*) - 1;*/

      //  QLineSeries *series = new QLineSeries();
        //QChart *chart = new QChart();

/******
 *For the testing of this class graphing will only use
 *fake values to show that it can work from the GUI
******/
       /* series->append(1,1);
        series->append(2,4);
        series->append(3,9);
        series->append(4,16);

        chart->legend()->hide();
        chart->addSeries(series);
        chart->setTitle("Test");
        chart->createDefaultAxes();
        chart->setAnimationOptions(QChart::SeriesAnimations);

        QChartView *chartView = new QChartView(chart);
        chartView->setRenderHint(QPainter::Antialiasing);
*/


       /* QMainWindow window;
        window.setCentralWidget(chartView);
        window.resize(420, 300);
        window.show();*/

       // return chartView;
}
