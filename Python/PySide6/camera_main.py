import sys
import cv2
import numpy as np
from PySide6.QtWidgets import QApplication, QMainWindow #화면을 만드는 도구
from PySide6.QtCore import QTimer
from PySide6.QtGui import QImage, QPixmap
from camera import Ui_MainWindow # designer로 만든 ui를 가져옴
import datetime

class CameraApp(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super(CameraApp, self).__init__() # 부모 클래스의 초기화 함수를 실행합니다
        self.setupUi(self) #화면을 설정합니다 /  a = Ui_MainWindow / a.setupUi 부모 객체에서 사용하는 함수
                                            #/  b = CameraApp / b.setupUi 자식 객채에서 상속받아 사용하는 함수

        self.cap = None # 카메라 지정 변수
        self.timer = QTimer() # 계속 타이머가 돌면서 카메라 상태 확인용
        self.timer.timeout.connect(self.update_frame) # 타이머가 끝날 때마다 이벤트 발생

        self.fps = 30 # 1초당 화면에 나오는 프레임이 30번 바뀜
        self.sens = 500 # 움직임에 따라서 얼마나 감지할 수 있는지 확인하는 척도

        self.btn_start.clicked.connect(self.start_camera) # 켜키 이벤트
        self.btn_stop.clicked.connect(self.stop_camera) # 끄기 이벤트

        self.sd_fps.setMinimum(1) # fps 최소값 1
        self.sd_fps.setMaximum(60) # fps 최소값 1
        self.sd_fps.setValue(self.fps) # 처음 시작할 때 지정해둔 fps 값으로 시작
        self.sd_fps.valueChanged.connect(self.set_fps) # 슬라이더로 fps 값 바꿀때 이벤트

        self.sd_sensitivity.setMinimum(0) # 감도 최소값 0
        self.sd_sensitivity.setMaximum(1000) # 감도 최대값 1000
        self.sd_sensitivity.setValue(self.sens) # 처음 시작할 때 지정해둔 감도 값으로 시작
        self.sd_sensitivity.valueChanged.connect(self.set_sens) # 슬라이더로 감도 값 바꿀때 이벤트

    def start_camera(self):
        if self.cap is None:
            self.cap  = cv2.VideoCapture(0) # 컴퓨터에 연결 되어있는 0번 카메라 불러오기
        if not self.timer.isActive():
            self.timer.start(int(1000 / self.fps)) # 1초 단위로 프레임을 30번 바꿈

    def stop_camera(self):
        if self.timer.isActive(): # 타이머가 실행중이면 끄기
            self.timer.stop()
        if self.cap is not None: # 카메라가 변수에 담겨있으면 해제하기
            self.cap.release()
            self.cap = None
        self.lbl_camera.clear() # 화면에 띄워진 영상을 라벨에서 제거

    def set_fps(self, value): # 슬라이더 자신과, 값을 전달
        self.fps = value 
        self.lbl_status_2.setText(f'{self.fps}') # 문자열 포맷팅해서 라벨에 값을 전달
        if self.timer.isActive():
             self.timer.start(int(1000 / self.fps))

    def set_sens(self, value): # 슬라이더 자신과, 값을 전달
        self.sens = value
        self.lbl_status_3.setText(f'{self.sens}') # 문자열 포맷팅해서 라벨에 값을 전달

    def update_frame(self):
        if self.cap is not None and self.cap.isOpened():
            ret, frame = self.cap.read() #화면의 한 장면을 변수에 담음 
            # ret : 장면을 받았는지 여부 bool / frame : 받아온 장면의 데이터를 변수에 저장
            if ret:
                gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) # 화면에서 받아온 한 장면을 회색으로 변경
                gray = cv2.GaussianBlur(gray, (21, 21), 0) # 회색으로 변경된 장면을 블러처리하여 새로 들어오는 장면과 비교하는 용도

                if not hasattr(self, 'pre_pic'): # hasattr(항목1, 항목2) 항목1에 항목 2가 있는지 물어봄
                    self.pre_pic = gray # 비교할 이전 사진
                    motion = False # 움직임 판단하는 변수
                else: 
                    frame_diff = cv2.absdiff(self.pre_pic, gray) #이미지 비교(이전에 들어온 사진, 방금 들어온 사진)
                    thresh = cv2.threshold(frame_diff, self.sens // 10, 255, cv2.THRESH_BINARY)[1] # (움직임)차이가 크면 흰색, 없으면 검은색
                    motion = np.sum(thresh) > 0 # 흰색일 경우 움직이 있다고 판단

                    self.pre_pic = gray # 현재 받아온 이미지를 이전 이미지로 설정

                
                # 움직임이 있으면 시간을 표시
                if motion:
                    now = datetime.datetime.now().strftime("%Y%m%d %H:%M:%S")
                    self.lbl_status.setText(f'{now}')
                else:
                    self.lbl_status.setText('변동없음')

                # 화면에 사진을 나타내주는 부분
                rgb_img = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
                h, w, ch = rgb_img.shape
                byte_line = ch * w
                qt_img = QImage(rgb_img.data, w, h, byte_line, QImage.Format_RGB888)
                pxm = QPixmap.fromImage(qt_img)
                self.lbl_camera.setPixmap(pxm)


# 프로그램이 직접 실행될 때 실행되는 코드
if __name__ == "__main__":
    app = QApplication() # 프로그램 만듦
    window = CameraApp() #메인 창을 만듦
    window.show() # 창을 보여줍니다
    app.exec() #프로그램을 실행합니다