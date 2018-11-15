#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "graphdisplay.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private Q_SLOTS:
    void on_updateButton_released();

    void on_calcButton_released();

    void on_graphButton_released();

    void on_mapButton_released();

    void on_saveButton_released();

    void on_closeButton_released();



    void on_stationList_pressed(const QModelIndex &index);

private:
    Ui::MainWindow *ui;
	graphDisplay* graphform;
	
	
};

#endif // MAINWINDOW_H
