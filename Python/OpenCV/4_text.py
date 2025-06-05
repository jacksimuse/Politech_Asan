import cv2
import numpy as np

#cv2.FONT_HERSHEY_SIMPLEX : 보통 크기의 산세리프 글꼴
#cv2.FONT_HERSHEY_PLAIN : 작은 크기의 산세리프 글꼴
#cv2.FONT_HERSHEY_DUPLEX : 보통 크기의 더블레이트 글꼴
#cv2.FONT_HERSHEY_COMPLEX : 보통 크기의 복잡한 글꼴
#cv2.FONT_HERSHEY_TRIPLEX : 보통 크기의 삼중 글꼴
#cv2.FONT_HERSHEY_COMPLEX_SMALL : 작은 크기의 복잡한 글꼴
#cv2.FONT_HERSHEY_SCRIPT_SIMPLEX : 보통 크기의 스크립트 글꼴
#cv2.FONT_HERSHEY_SCRIPT_COMPLEX : 보통 크기의 스크립트 복잡한 글꼴

# img = np.zeros((500,500,3), dtype=np.uint8)

# cv2.putText(img, "Hello", (10, 50), cv2.FONT_HERSHEY_COMPLEX, 1, (150, 150, 150), 2)
# cv2.putText(img, "안녕하세요", (10, 100), cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (150, 150, 150), 2)
# cv2.putText(img, "한국폴리텍", (10, 150), cv2.FONT_HERSHEY_DUPLEX, 1, (150, 150, 150), 2)
# cv2.putText(img, "반도체 장비과", (10, 200), cv2.FONT_HERSHEY_PLAIN, 1, (150, 150, 150), 2)
# cv2.putText(img, "Hello", (10, 250), cv2.FONT_HERSHEY_SCRIPT_COMPLEX, 1, (150, 150, 150), 2)
# cv2.putText(img, "Hello", (10, 300), cv2.FONT_HERSHEY_SCRIPT_SIMPLEX, 1, (150, 150, 150), 2)
# cv2.putText(img, "Hello", (10, 350), cv2.FONT_HERSHEY_SIMPLEX, 1, (150, 150, 150), 2)
# cv2.putText(img, "Hello", (10, 400), cv2.FONT_HERSHEY_TRIPLEX, 1, (150, 150, 150), 2)


# cv2.imshow('img', img)
# cv2.waitKey(0)
# cv2.destroyAllWindows()

# PIL (Python Image Library)
from PIL import ImageFont, ImageDraw, Image

def KPutText(src, text, pos, fontface, font_size, color):
    img_pil = Image.fromarray(src)
    draw = ImageDraw.Draw(img_pil)
    font = ImageFont.truetype(f"C:/Windows/Fonts/{fontface}", font_size)
    draw.text(pos, text, font = font, fill = color)
    return np.array(img_pil)

main = np.zeros((500, 500, 3), dtype=np.uint8)
main = KPutText(main, "안녕하세요", (10,150),"gulim.ttc", 30, (100,100,100))
main = KPutText(main, "안녕하세요", (10,250), "batang.ttc", 30, (100,100,100))
main = KPutText(main, "안녕하세요", (10,350), "NanumSquareR.ttf", 30, (100,100,100))

cv2.imshow('img', main)
cv2.waitKey(0)
cv2.destroyAllWindows()