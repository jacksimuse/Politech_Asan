import cv2
import numpy as np

img = cv2.imread('test.jpg')

# 흑백 변환
# 컬러에서 흑백 변환하면 데이터 용량 감소, 이미지 전처리가 가능
# 가중치 (0.299*R + 0.587*G + 0.114*B) / opencv에서 제공하는 기본 가중치 값
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
# cv2.imshow('gray', gray)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# 각 채널(R,G,B)의 평균값을 사용하여 흑백 이미지를 만든다.
avg_gray = np.mean(img, axis=2).astype(np.uint8)
# cv2.imshow("avg_gray", avg_gray)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# 각 채널 (R,G,B) 중 하나의 색만 빼내서 흑백으로 변환
red_channel = img[:, :, 2] # img.shape -> 높이, 너비, 채널 3색
blue_channel = img[:, :, 0] # img.shape -> 높이, 너비, 채널 3색
green_channel = img[:, :, 1] # img.shape -> 높이, 너비, 채널 3색
# 0 블루, 1 그린, 2 레드
# cv2.imshow("red_channel", red_channel)
# cv2.imshow("blue_channel", blue_channel)
# cv2.imshow("green_channel", green_channel)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# HSV H : 색상, S : 채도 V : 명도
hsv = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)
v_channel = hsv[:, :, 2]
h_channel = hsv[:, :, 0]
s_channel = hsv[:, :, 1]
# 0 색상, 1 채도, 2 명도
# cv2.imshow("v_channel", v_channel)
# cv2.imshow("h_channel", h_channel)
# cv2.imshow("s_channel", s_channel)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# 흐림 변환
# 노이즈 줄이기, 경계선 약화

# 평균 흐림(블러)
# 커널(필터)에 있는 모든 픽셀의 평균값으로 대체
# avg_blur3 = cv2.blur(img, (3,3))
# avg_blur5 = cv2.blur(img, (5,5))
# avg_blur7 = cv2.blur(img, (7,7))
# avg_blur9 = cv2.blur(img, (9,9))
# cv2.imshow('avg_blur3', avg_blur3)
# cv2.imshow('avg_blur5', avg_blur5)
# cv2.imshow('avg_blur7', avg_blur7)
# cv2.imshow('avg_blur9', avg_blur9)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# 가우시안 블러
# gaus_blur3 = cv2.GaussianBlur(img, (3,3), 0.1)
# gaus_blur5 = cv2.GaussianBlur(img, (5,5), 0.2)
# gaus_blur7 = cv2.GaussianBlur(img, (7,7), 0.3)
# gaus_blur9 = cv2.GaussianBlur(img, (9,9), 0)
# cv2.imshow('gaus_blur3', gaus_blur3)
# cv2.imshow('gaus_blur5', gaus_blur5)
# cv2.imshow('gaus_blur7', gaus_blur7)
# cv2.imshow('gaus_blur9', gaus_blur9)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# # 미디언 블러
# # 커널 내의 중앙값으로 픽셀을 대체 / 소금-후추 노이즈 제거에 용이
# median_blur = cv2.medianBlur(img, 9)
# cv2.imshow('median_blur', median_blur)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# 원근 (perspectiveTransform) 변환 / 관점 변환
# 문서의 글자 스캔, 교정, 특정 영역에 사용
height, width = img.shape[:2] # 높이, 너비 / 색상 채널
src = np.float32([[0,0], [width,0], [0, height], [width,height]]) # 원본 좌표
dst = np.float32([[50,50], [width,30], [70, height], [width - 30, height -70]]) # 바꿔줄 좌표
matrix = cv2.getPerspectiveTransform(src, dst) # getPerspectiveTransform / perspectiveTransform

dst2 = np.float32([[10,10], [50,50]])
matrix2 = cv2.perspectiveTransform(src, dst2) # (a b)
                                              # (c d)
pers = cv2.warpPerspective(img, matrix, (width, height))
cv2.imshow('pers', pers)
cv2.waitKey(0)
cv2.destroyAllWindows()

