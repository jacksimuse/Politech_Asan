import cv2

img = cv2.imread('sample.jpg') # 해당 경로의 파일 읽어오기
cv2.imshow('img', img) #cv2.imshow('창 이름', 소스 or 파일)
cv2.waitKey(0) #키를 받을 때 까지 대기 0이면 무한, 나머지는 ms만큼 대기 후 코드가 끝남
cv2.destroyAllWindows #창 닫기


img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY) # cv2.cvtColor(원본, 바꿔줄 코드)

cv2.imshow("gray img", img_gray)
cv2.waitKey(0) #키를 받을 때 까지 대기 0이면 무한, 나머지는 ms만큼 대기 후 코드가 끝남
cv2.destroyAllWindows #창 닫기

cv2.imwrite("gray sample.jpg", img_gray)

print(cv2.imwrite("gray sample.jpg", img_gray))

