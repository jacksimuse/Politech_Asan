a = 1


# a = a + 1 / a += 1 같은 표현
a = a + 1
a += 1

# a = a - 1 / a -= 1 같은 표현
a = a - 1
a -= 1

print(a) # 2


b = 2
print(b) # 2
b += 2 # b = b + 2
print(b) # 4
b -= 2 # b = b - 2
print(b) # 2
b *= 2 # b = b * 2
print(b) # 4
b /= 2 # b = b / 2
print(b) # 2.0
b **= 2 # b = b ** 2
print(b) # 4.0
b %= 2  # b = b % 2
print(b) # 0.0
b //= 2 # b = b // 2
print(b) # 0.0

# 변수 c에 5를 대입하고 복합 연산자 +=, -=, *=, /=, **=, %=, //=을 사용해서 출력해주세요
c = 5
print(c) # 5
c += 5
print(c) # 10
c -= 5
print(c) # 5
c *= 5
print(c) # 25
c /= 5
print(c) # 5.0
c **= 5
print(c) # 3125.0
c %= 5
print(c) # 0.0
c //= 5
print(c) # 0.0
