import cv2
import numpy as np

# 가로세로 1000인 흰색 도화지
img = np.zeros((800, 800, 3), dtype=np.uint8)
img[:] = (255,255,255)

cv2.circle(img, (350, 150), 100, (100, 100, 100), 10)
cv2.rectangle(img, (250, 200), (450, 400), (128,0,128), 5)
cv2.line(img, (100,300), (300,300), (200,200,200), 2, cv2.LINE_AA)
cv2.line(img, (450,300), (650,300), (200,200,200), 2, cv2.LINE_AA)

#pt = np.array([])
#cv2.polylines(img, )


cv2.imshow('img', img)
cv2.waitKey(0)
cv2.destroyAllWindows()