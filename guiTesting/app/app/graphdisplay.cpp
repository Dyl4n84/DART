#include "graphdisplay.h"
#include "ui_graphdisplay.h"

graphDisplay::graphDisplay(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::graphDisplay)
{
    ui->setupUi(this);
}

graphDisplay::~graphDisplay()
{
    delete ui;
}
