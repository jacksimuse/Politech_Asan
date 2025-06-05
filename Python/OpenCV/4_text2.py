import cv2
import numpy as np
from PIL import ImageFont, ImageDraw, Image
from datetime import datetime

def KPutText(src, text, pos, fontface, font_size, color):
    img_pil = Image.fromarray(src)
    draw = ImageDraw.Draw(img_pil)
    font = ImageFont.truetype(f"C:/Windows/Fonts/{fontface}", font_size)
    draw.text(pos, text, font = font, fill = color)
    return np.array(img_pil)

main = np.zeros((800, 800, 3), dtype=np.uint8)
main[:] = (50, 50, 50)

current_time = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
cv2.putText(main, current_time, (10, 100), cv2.FONT_HERSHEY_SCRIPT_SIMPLEX, 1, (150, 150, 150), 2)

cv2.putText(main, "Pos : (300, 300)", (250,250), cv2.FONT_HERSHEY_COMPLEX, 1, (5,120,200), 1)
cv2.circle(main, (300, 300), 20, (200,200,200), -1)

main = KPutText(main, "글자 연습중", (10, 150), "gulim.ttc", 50, (200,100,250))


cv2.imshow('img', main)
cv2.waitKey(0)
cv2.destroyAllWindows()