/********************************************************************************
** Form generated from reading UI file 'graphdisplay.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_GRAPHDISPLAY_H
#define UI_GRAPHDISPLAY_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_graphDisplay
{
public:
    QComboBox *comboBox;

    void setupUi(QWidget *graphDisplay)
    {
        if (graphDisplay->objectName().isEmpty())
            graphDisplay->setObjectName(QString::fromUtf8("graphDisplay"));
        graphDisplay->resize(400, 300);
        comboBox = new QComboBox(graphDisplay);
        comboBox->setObjectName(QString::fromUtf8("comboBox"));
        comboBox->setGeometry(QRect(70, 180, 91, 32));

        retranslateUi(graphDisplay);

        QMetaObject::connectSlotsByName(graphDisplay);
    } // setupUi

    void retranslateUi(QWidget *graphDisplay)
    {
        graphDisplay->setWindowTitle(QApplication::translate("graphDisplay", "Form", nullptr));
    } // retranslateUi

};

namespace Ui {
    class graphDisplay: public Ui_graphDisplay {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_GRAPHDISPLAY_H
