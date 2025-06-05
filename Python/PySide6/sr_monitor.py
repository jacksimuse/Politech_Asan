# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'serial_monitor.ui'
##
## Created by: Qt User Interface Compiler version 6.9.0
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QBrush, QColor, QConicalGradient, QCursor,
    QFont, QFontDatabase, QGradient, QIcon,
    QImage, QKeySequence, QLinearGradient, QPainter,
    QPalette, QPixmap, QRadialGradient, QTransform)
from PySide6.QtWidgets import (QApplication, QComboBox, QFormLayout, QLabel,
    QLineEdit, QMainWindow, QMenuBar, QPushButton,
    QSizePolicy, QStatusBar, QTextEdit, QWidget)

class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        if not MainWindow.objectName():
            MainWindow.setObjectName(u"MainWindow")
        MainWindow.resize(223, 317)
        self.centralwidget = QWidget(MainWindow)
        self.centralwidget.setObjectName(u"centralwidget")
        self.formLayout = QFormLayout(self.centralwidget)
        self.formLayout.setObjectName(u"formLayout")
        self.lbl_port = QLabel(self.centralwidget)
        self.lbl_port.setObjectName(u"lbl_port")
        self.lbl_port.setAlignment(Qt.AlignLeading|Qt.AlignLeft|Qt.AlignVCenter)

        self.formLayout.setWidget(0, QFormLayout.ItemRole.LabelRole, self.lbl_port)

        self.cbo_port = QComboBox(self.centralwidget)
        self.cbo_port.setObjectName(u"cbo_port")

        self.formLayout.setWidget(0, QFormLayout.ItemRole.FieldRole, self.cbo_port)

        self.lbl_baud = QLabel(self.centralwidget)
        self.lbl_baud.setObjectName(u"lbl_baud")

        self.formLayout.setWidget(1, QFormLayout.ItemRole.LabelRole, self.lbl_baud)

        self.cbo_baud = QComboBox(self.centralwidget)
        self.cbo_baud.setObjectName(u"cbo_baud")

        self.formLayout.setWidget(1, QFormLayout.ItemRole.FieldRole, self.cbo_baud)

        self.btn_open = QPushButton(self.centralwidget)
        self.btn_open.setObjectName(u"btn_open")

        self.formLayout.setWidget(2, QFormLayout.ItemRole.LabelRole, self.btn_open)

        self.btn_close = QPushButton(self.centralwidget)
        self.btn_close.setObjectName(u"btn_close")

        self.formLayout.setWidget(2, QFormLayout.ItemRole.FieldRole, self.btn_close)

        self.le_write = QLineEdit(self.centralwidget)
        self.le_write.setObjectName(u"le_write")

        self.formLayout.setWidget(3, QFormLayout.ItemRole.LabelRole, self.le_write)

        self.btn_write = QPushButton(self.centralwidget)
        self.btn_write.setObjectName(u"btn_write")

        self.formLayout.setWidget(3, QFormLayout.ItemRole.FieldRole, self.btn_write)

        self.txt_result = QTextEdit(self.centralwidget)
        self.txt_result.setObjectName(u"txt_result")

        self.formLayout.setWidget(4, QFormLayout.ItemRole.SpanningRole, self.txt_result)

        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QMenuBar(MainWindow)
        self.menubar.setObjectName(u"menubar")
        self.menubar.setGeometry(QRect(0, 0, 223, 21))
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QStatusBar(MainWindow)
        self.statusbar.setObjectName(u"statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        self.btn_open.clicked.connect(MainWindow.bOpen)
        self.btn_close.clicked.connect(MainWindow.bClose)
        self.btn_write.clicked.connect(MainWindow.bWrite)

        QMetaObject.connectSlotsByName(MainWindow)
    # setupUi

    def retranslateUi(self, MainWindow):
        MainWindow.setWindowTitle(QCoreApplication.translate("MainWindow", u"MainWindow", None))
        self.lbl_port.setText(QCoreApplication.translate("MainWindow", u"Port", None))
        self.lbl_baud.setText(QCoreApplication.translate("MainWindow", u"Buadrate", None))
        self.btn_open.setText(QCoreApplication.translate("MainWindow", u"Open", None))
        self.btn_close.setText(QCoreApplication.translate("MainWindow", u"Close", None))
        self.btn_write.setText(QCoreApplication.translate("MainWindow", u"Write", None))
    # retranslateUi

