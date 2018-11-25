#-------------------------------------------------
#
# Project created by QtCreator 2018-10-14T11:07:43
#
#-------------------------------------------------

QT  += core gui
QT  += webkitwidgets

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = NOAA_Maine
TEMPLATE = app

# The following define makes your compiler emit warnings if you use
# any feature of Qt which has been marked as deprecated (the exact warnings
# depend on your compiler). Please consult the documentation of the
# deprecated API in order to know how to port your code away from it.
DEFINES += QT_DEPRECATED_WARNINGS

DESTDIR = $$PWD

# You can also make your code fail to compile if you use deprecated APIs.
# In order to do so, uncomment the following line.
# You can also select to disable deprecated APIs only up to a certain version of Qt.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0

SOURCES += \
        main.cpp \
        mainwindow.cpp \
    graphdisplay.cpp \
    buoy.cpp

HEADERS += \
        mainwindow.h \
    graphdisplay.h \
    buoy.h \

FORMS += \
        mainwindow.ui \
    graphdisplay.ui

OTHER_FILES += \
        latest_obs* \
        Map_USA_Northeast.png \
        scrape_NOAA_buoy.py \

RESOURCES += \
        StationPictures \

CONFIG += no_keywords # Python redefines some qt keywords
INCLUDEPATH += /usr/include/python3.6

LIBS += -L/usr/lib/python3.6
QMAKE_CXXFLAGS += -L/usr/lib/python3.6