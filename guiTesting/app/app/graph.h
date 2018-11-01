#ifndef GRAPH_H
#define GRAPH_H
#include<QList>
#include<QString>
#include <QtCharts/QChartView>

QT_CHARTS_USE_NAMESPACE

class graph
{
public:
    graph();
    ~graph();
    void get_graphing_info();
    QChartView* line_graph();

private:
    QList<double> *data;
    QString name;

};

#endif // GRAPH_H
