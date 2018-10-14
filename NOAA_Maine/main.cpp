#include "mainwindow.h"
#include <QApplication>
#include <QtWebKitWidgets>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

    w.show();

    return a.exec();
}
