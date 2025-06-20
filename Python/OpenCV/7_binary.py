import cv2
import numpy as np
import matplotlib.pyplot as plt

img = cv2.imread('sudoku.jpg', cv2.IMREAD_GRAYSCALE) # 이미지를 불러올때 흑백처리
# gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY) # 불러온 이미지를 흑백처리

# plt.imshow(img, cmap="gray")
# plt.show()

# # 임계값(Threshold)
# # 임계값 종류 THRESH_BINARY, THRESH_BINARY_INV, THRESH_TRUNC, THRESH_TOZERO, THRESH_TOZERO_INV
# # threshold(이미지 대상, 임계값, 최대값, 임계값 종류)
# bin50 = cv2.threshold(img, 50, 255, cv2.THRESH_BINARY)[1] # 임계값이 50이고 픽셀 값이 50을 넘으면 255로 변환, 못넘으면 0으로 변환
# bin100 = cv2.threshold(img, 100, 255, cv2.THRESH_BINARY)[1] # 임계값이 100이고 픽셀 값이 50을 넘으면 255로 변환, 못넘으면 0으로 변환
# bin150 = cv2.threshold(img, 150, 255, cv2.THRESH_BINARY)[1] # 임계값이 150이고 픽셀 값이 50을 넘으면 255로 변환, 못넘으면 0으로 변환

# fig, subs = plt.subplots(ncols = 3, figsize = (10, 5), sharex = True, sharey = True)
# subs[0].set_title('bin50')
# subs[0].imshow(bin50, cmap = 'gray')

# subs[1].set_title('bin100')
# subs[1].imshow(bin100, cmap = 'gray')

# subs[2].set_title('bin150')
# subs[2].imshow(bin150, cmap = 'gray')
# plt.show()


binary = None

def on_trackbar(val):
    global binary
    _, binary = cv2.threshold(img, val, 255, cv2.THRESH_BINARY)
    cv2.imshow('bin_val', binary)

cv2.namedWindow('bin_val')
cv2.createTrackbar('thresh', 'bin_val', 0, 255, on_trackbar)
on_trackbar(0)

cv2.waitKey(0)
cv2.destroyAllWindows()


# Otsu의 이진화(Otsu's Thresholding)
_, binary_otsu = cv2.threshold(img, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)
cv2.imshow('otsu', binary_otsu)
cv2.waitKey(0)
cv2.destroyAllWindows()