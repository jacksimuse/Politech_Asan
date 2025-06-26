import cv2
import numpy as np
import matplotlib.pyplot as plt

# 이미지를 흑백로 전처리 
src = cv2.imread('wafer.png', cv2.IMREAD_GRAYSCALE)

# 이미지 침식 팽창에 사용되는 커널을 제작
kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (3,1))
kernel2 = cv2.getStructuringElement(cv2.MORPH_RECT, (5,5))

# 침식 연산(대상 이미지, 커널)
dst1 = cv2.erode(src, kernel)
dst2 = cv2.erode(src, kernel2)

# 팽창 연산(대상 이미지, 커널)
src2 = cv2.imread('wafer2.png', cv2.IMREAD_GRAYSCALE)
dst3 = cv2.dilate(src2, kernel)
dst4 = cv2.dilate(src2, kernel2)

# cv2.imshow('src2', src2)
# cv2.imshow('dst1', dst1)
# cv2.imshow('dst2', dst2)
# cv2.imshow('dst3', dst3)
# cv2.imshow('dst4', dst4)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

_, temp = cv2.threshold(src, 0, 255, cv2.THRESH_BINARY)
_, temp2 = cv2.threshold(src2, 0, 255, cv2.THRESH_BINARY)
# 열림 함수(침식-팽창 순서로 연산)
dst5 = cv2.morphologyEx(temp, cv2.MORPH_OPEN, kernel)
# 닫힘 함수(팽창-침식 순서로 연산)
dst6 = cv2.morphologyEx(temp, cv2.MORPH_CLOSE, kernel)

dst7 = cv2.morphologyEx(temp2, cv2.MORPH_OPEN, kernel)
dst8 = cv2.morphologyEx(temp2, cv2.MORPH_CLOSE, kernel)


# cv2.imshow('dst5', dst5)
# cv2.imshow('dst6', dst6)
cv2.imshow('dst7', dst7)
cv2.imshow('dst8', dst8)
cv2.waitKey(0)
cv2.destroyAllWindows()

