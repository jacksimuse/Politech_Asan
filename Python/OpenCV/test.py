import cv2


cap = cv2.VideoCapture(0)  
# 연결이 성공했는지 확인
if not cap.isOpened():
    print("카메라를 열 수 없습니다.")
    exit()

while True:
    ret, frame = cap.read()
    if not ret:
        print("프레임을 읽을 수 없습니다.")
        break
        
    cv2.imshow('Android Camera', frame)
    
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows()
    
# 사용 가능한 카메라 장치 확인
for i in range(10):
    cap = cv2.VideoCapture(i)
    if cap.isOpened():
        print(f"카메라 {i} 사용 가능")
        cap.release()
    else:
        print(f"카메라 {i} 사용 불가")
    
