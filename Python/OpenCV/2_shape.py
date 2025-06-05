import cv2
import numpy as np

# 가로, 세로 300, 색 채널 3가지인 캔버스
#main = np.zeros((500, 500, 3), dtype=np.uint8)
# main[100:300] = (255, 255, 255) # 캔버스에 배열을 통해서 지정한 크기만큼 색칠할 수 있음

# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 직선
# cv2.line(main, (51,42), (300,42), (255, 255, 255), 2, cv2.LINE_4)
# cv2.line(main, (81,102), (124,60), (255, 255, 255), 2, cv2.LINE_8)
# cv2.line(main, (151,242), (364,142), (255, 255, 255), 2, cv2.LINE_AA)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 그림판에서 마우스 위치 확인하고 사각형 그리기 
# 두께랑 색깔은 마음에 드는 걸로 전부 다르게

# cv2.line(main, (137,167), (329,163), (0, 0, 255), 2, cv2.LINE_8)
# cv2.line(main, (137,167), (137,256), (255, 255, 255), 5, cv2.LINE_AA)
# cv2.line(main, (137,256), (329,256), (0, 255, 0), 1, cv2.LINE_AA)
# cv2.line(main, (329,163), (329,256), (255, 0, 0), 6, cv2.LINE_4)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 사각형 그리기
# cv2.rectangle(main, (150, 150), (300, 300), (128,0,128), 5)
# cv2.rectangle(main, (50, 50), (100, 100), (128,0,128), cv2.FILLED)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 원 그리기
# cv2.circle(main, (250, 250), 100, (100, 100, 100), 10)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 타원 그리기
# cv2.ellipse(main, (100, 100), (100, 50), 90, 0, 180, (150, 150, 150), 2)
# cv2.ellipse(main, (300, 300), (100, 50), 0, 0, 360, (150, 150, 150), cv2.FILLED)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows

# 다각형 그리기
# point1 = np.array([[100,100], [100,200], [200,100]])
# cv2.polylines(main, [point1], False, (255,0,0), 3)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows


# point2 = np.array([[100,100], [100,400], [400,100]])
# cv2.fillPoly(main, [point2],(0, 255, 0), cv2.LINE_AA)
# cv2.imshow('img', main)
# cv2.waitKey(0)
# cv2.destroyAllWindows



