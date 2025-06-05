import cv2
import numpy as np

img = cv2.imread("sample.jpg")

# 이미지 자르기
cut = img[100:500, 100:500] # (100, 100) -> (500, 500)
cv2.imwrite("cut_img.jpg", cut)

# 이미지 사이즈 변경
resized = cv2.resize(img, (800, 800)) # 고정값 변환
resized2 = cv2.resize(img, None, fx= 1.5, fy=1.1) # 비율로 변환

cv2.imshow('resized img', resized)
cv2.imshow('resized2 img', resized2)

# 이미지 회전
height, width = img.shape[:2] # img.shape -> 높이, 너비, 색상 수 / img.shape[:2] -> 높이, 너비
rotation_matrix = cv2.getRotationMatrix2D((width/2, height/2), 180, 2)
rotate = cv2.warpAffine(img, rotation_matrix, (width, height))

# 밝기
bright = np.clip(img + 10, 0, 255).astype(np.uint8) # 밝게
dark = np.clip(img - 10, 0, 255).astype(np.uint8) # 밝게

# cv2.imshow('bright img', bright)
# cv2.imshow('dark img', dark)
cv2.waitKey(0)
cv2.destroyAllWindows


# 원본을 가지고 사이즈 고정, 비율로 변환하기
# 사진을 흑백으로 바꾸고 270도 회전시키기
# 밝은거 1개 어두운거 1개 만들고 저장시키기