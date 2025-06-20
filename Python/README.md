# 수업내용은 이곳에 올라옵니다.

2025-06-20 수업

1. 흑백 변환
- OpenCV에서 제공 가중치로 흑백 변환
cv2.cvtColor(BGR2GRAY) 
- 각 채널의 색을 빼서 만드는 흑백
img[:,:,2] 
- 각 채널의 평균값을 사용해서 흑백
np.mean(img, axis=2)
- hsv에서 V명도로 흑백 변환
cv2.cvtColor(BGR2HSV)
hsv[:,:,2]

2. 흐림 변환
- 평균 블러
cv2.blur(img, (7,7)) 
- 가우시안 블러
cv2.GaussianBlur(img, (7,7)) 
- 미디언 블러
cv2.medianBlur(img, 7)

3. 원근 변환(관점 변환)
1. src, dst / 원본 좌표, 변경될 좌표
2. getPerspectiveTransform

4. 이진화 변화(임계값을 통한 노이즈 처리)
- THRESH_BINARY
- THRESH_BINARY_INV
- THRESH_TRUNC
- THRESH_TOZERO
- THRESH_TOZERO_INV
- OTSU
- 적응형 이진화

