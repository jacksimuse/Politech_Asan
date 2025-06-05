#필요한 도구를 가져옵니다
from PySide6.QtWidgets import QApplication, QMainWindow #화면을 만드는 도구
from sr_monitor import Ui_MainWindow # designer로 만든 ui를 가져옴
from PySide6.QtCore import QThread #여러 일을 동시에 할 수 있게 해줌
from PySide6.QtSerialPort import QSerialPortInfo # 시리얼 포트 정보 가져오는 도구
from serial import Serial # 시리얼 통신을 가져오기 위한 도구


# SerialMonitor 프로그램 메인 클래스
class SerialMonitor(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super(SerialMonitor, self).__init__() # 부모 클래스의 초기화 함수를 실행합니다
        self.setupUi(self) #화면을 설정합니다 /  a = Ui_MainWindow / a.setupUi 부모 객체에서 사용하는 함수
                                            #/  b = SerialMonitor / b.setupUi 자식 객채에서 상속받아 사용하는 함수
        port_list = QSerialPortInfo.availablePorts() # 현재 시스템에서 사용가능한 포트목록 가져오기
        # [COM1, COM2, COM7]
        for i, port in enumerate(port_list): # 반복문을 통해 list 값을 combobox에 삽입   
            self.cbo_port.insertItem(i, port.portName())
        # 순서대로 0, 1, 2 .... 하나씩 삽입 됨

        baud_list = ['9600', '19200', '38400', '57600', '115200'] # 통신 속도 목록 만들기
        for i, baud in enumerate(baud_list): # 반복문을 통해 list 값을 combobox에 삽입   
            self.cbo_baud.insertItem(i, baud)
        # 순서대로 0, 1, 2 .... 하나씩 삽입 됨

        self.dev = None # 시리얼 통신 장치를 저장할 변수

        self.receiver = RecvThread(self) # 데이터를 받는 스레드를 만듭니다

    def bOpen(self):    # 시리얼 통신, 포트를 열어주는 메서드
        current_port = self.cbo_port.currentText() # 현재 port 콤보박스에 있는 글자를 가져옴
        current_baud = int(self.cbo_baud.currentText()) # 현재 baud 콤보박스에 있는 글자를 가져옴

        self.dev = Serial(current_port, current_baud) # 시리얼 통신 장치 설정

        try:
            self.receiver.start() # 스레드 시작, 가동
        except Exception as e:
            print("오류 발생: ", str(e)) # 오류 메세지
        
    def bClose(self): # 시리얼 포트 닫는 함수(메서드)
        if self.dev: # 장치가 있을 때
            if self.dev.isOpen(): # 장치가 열려있을 때
                self.dev.close() #포트 닫기
                self.dev = None # 장치 해제
            else:
                print('이미 닫힘')
        else:
            print('연결된 장치가 없습니다')


    def bWrite(self): #데이터를 보내는 함수(메서드)
        if self.dev: # 장치가 있을 때
            if self.dev.isOpen(): 
                msg = self.le_write.text() # 입력창에 있는 글자를 가져옴
                self.dev.write(msg.encode('ascii')) #메세지를 장치에 보냅니다
                self.txt_result.append("TX >> " + str(msg.encode('ascii'))) # 보낸 내용을 화면에 표시
                print("보낸 메세지 : " + str(msg.encode('ascii')))
            else:
                print("닫힘")
        else:
            print("장치 없음")


# 데이터를 받는 스레드 클래스
class RecvThread(QThread):
    def __init__(self, parent):
        super(RecvThread, self).__init__(parent) # 부모 클래스의 초기화 함수를 실행
        self.sr_monitor = parent # 부모 창을 저장
        self.is_running = False # 실행 상태를 확인하는 플래그

    def run(self):
        # 장치가 준비될 때까지 기다립니다.
        while not self.sr_monitor.dev:
            pass

        # 장치가 열릴 때까지 기다립니다
        while not self.sr_monitor.dev.isOpen():
            pass

        self.is_running = True # 실행 상태를 True로 설정

        #데이터를 계속 받아옵니다
        while self.is_running:
            msg = self.sr_monitor.dev.readline() # 한 줄씩 데이터를 읽어옵니다.
            if msg:
                self.sr_monitor.txt_result.append("RX >> " + str(msg.decode('ascii')))



# 프로그램이 직접 실행될 때 실행되는 코드
if __name__ == "__main__":
    app = QApplication() # 프로그램 만듦
    window = SerialMonitor() #메인 창을 만듦
    window.show() # 창을 보여줍니다
    app.exec() #프로그램을 실행합니다
