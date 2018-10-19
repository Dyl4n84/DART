/****************************************************************************
**
** Copyright (C) 2016 The Qt Company Ltd.
** Contact: https://www.qt.io/licensing/
**
** This file is part of the Qt Charts module of the Qt Toolkit.
**
** $QT_BEGIN_LICENSE:GPL$
** Commercial License Usage
** Licensees holding valid commercial Qt licenses may use this file in
** accordance with the commercial license agreement provided with the
** Software or, alternatively, in accordance with the terms contained in
** a written agreement between you and The Qt Company. For licensing terms
** and conditions see https://www.qt.io/terms-conditions. For further
** information use the contact form at https://www.qt.io/contact-us.
**
** GNU General Public License Usage
** Alternatively, this file may be used under the terms of the GNU
** General Public License version 3 or (at your option) any later version
** approved by the KDE Free Qt Foundation. The licenses are as published by
** the Free Software Foundation and appearing in the file LICENSE.GPL3
** included in the packaging of this file. Please review the following
** information to ensure the GNU General Public License requirements will
** be met: https://www.gnu.org/licenses/gpl-3.0.html.
**
** $QT_END_LICENSE$
**
****************************************************************************/

#include <QtWidgets/QApplication>
#include <QtWidgets/QMainWindow>
#include <QtCharts/QChartView>
#include <QtCharts/QBarSeries>
#include <QtCharts/QBarSet>
#include <QtCharts/QLegend>
#include <QtCharts/QBarCategoryAxis>
#include <QtCharts/QValueAxis>

QT_CHARTS_USE_NAMESPACE

#define num_of_buoys 5
#define num_of_data_sets 5

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QList<QString> names[num_of_buoys];
    QList<qreal> data[num_of_buoys][num_of_data_sets];

//![1]

    QList<QBarSet *> names_to_append;
    for(int x = 0; x < num_of_buoys; x++){
        QBarSet *add = new QBarSet(names->at(x));
        names_to_append.append(add);
        delete add;
    }

//![1]


//![2]

    QBarSeries *series = new QBarSeries();
    series->append(names_to_append);

//![2]


//![3]
    QChart *chart = new QChart();
    chart->addSeries(series);
    chart->setTitle("NOAA Buoy Information");
    chart->setAnimationOptions(QChart::SeriesAnimations);
//![3]


//![4]
    QStringList categories;
    categories << "Jan" << "Feb" << "Mar" << "Apr" << "May" << "Jun";
    QBarCategoryAxis *axisX = new QBarCategoryAxis();
    axisX->append(categories);
    chart->addAxis(axisX, Qt::AlignBottom);
    series->attachAxis(axisX);

    QValueAxis *axisY = new QValueAxis();
    axisY->setRange(0,15);
    chart->addAxis(axisY, Qt::AlignLeft);
    series->attachAxis(axisY);
//![4]

//![5]
    chart->legend()->setVisible(true);
    chart->legend()->setAlignment(Qt::AlignBottom);
//![5]

//![6]
    QChartView *chartView = new QChartView(chart);
    chartView->setRenderHint(QPainter::Antialiasing);
//![6]

//![7]
    QMainWindow window;
    window.setCentralWidget(chartView);
    window.resize(420, 300);
    window.show();
//![7]

    return a.exec();
}
