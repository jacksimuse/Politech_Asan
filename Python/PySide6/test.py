import cv2  # OpenCV 라이브러리를 불러옵니다. 이 라이브러리는 카메라와 영상을 다루는데 사용됩니다.

# 컴퓨터에 연결된 카메라를 사용하기 위한 준비를 합니다.
# 0은 컴퓨터에 연결된 첫 번째 카메라를 의미합니다.
cap = cv2.VideoCapture(0)

# 카메라가 제대로 연결되었는지 확인합니다.
if not cap.isOpened():
    print('카메라를 연결할 수 없습니다')
    exit()

# 무한 반복문을 시작합니다. 이는 카메라가 계속해서 영상을 보여주기 위함입니다.
while True:
    # 카메라에서 한 장의 사진(프레임)을 읽어옵니다.
    # ret는 사진을 제대로 읽었는지 여부를 알려주고, frame은 실제 사진 데이터입니다.
    ret, frame = cap.read()
    
    # 사진을 제대로 읽지 못했다면 반복문을 종료합니다.
    if not ret:
        print('프레임을 읽을 수 없습니다.')
        break

    # 읽어온 사진을 화면에 보여줍니다.
    # '카메라 화면'이라는 제목으로 창을 만들어 사진을 표시합니다.
    cv2.imshow('test', frame)

    # 키보드에서 'q'를 누르면 반복문을 종료합니다.
    # 1은 1밀리초 동안 기다린다는 의미입니다.

    a = cv2.waitKey(0)


    if a == ord('q'):
        break


cap.release()

cv2.destroyAllWindows()