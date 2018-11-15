#ifndef GRAPHWINDOW_H
#define GRAPHWINDOW_H

#include "main.cpp"

namespace Ui {
class graphWindow;
}

class graphWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit graphWindow(QWidget *parent = nullptr);
    ~graphWindow();

private:
    Ui::graphWindow *ui;
    QChart *chart;
    QChartView *chartView;
    QGridLayout *gridLayout;

};

#endif // GRAPHWINDOW_H
