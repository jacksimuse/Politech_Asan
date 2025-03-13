# head = "Python "
# tail = " is fun! "
# total  = head + tail
# print(head + tail)
# print(total)

# print(total * 2)


# print('+' * 50)
# print("문자열 곱하기 표시")
# print('-' * 50)


# # # 총 3구역으로 나눕니다.
# # # 첫번째 구역은 '-'로 30개, 첫번째 구역 중간에는 "문자열 곱하기" + "연습" 이 내용을 출력
# # # 두번째 구역은 '+'로 50개, 두번째 구역 중간에는 "쌍 "따옴표"로 강조하기" 출력
# # # 세번째 구역은 '$'로 20개, 세번째 구역 중간에는 \n로 줄바꿈 문자열 만들기 "줄바꿈 문자 연습" 출력

# print('-' * 30)
# print("문자열 곱하기" + '연습')
# print('-' * 30)

# print()
# print()

# print('+' * 50)
# print("쌍 \"따옴표\"로 강조하기")
# print('+' * 50)

# print()
# print()

# print('$' * 20)
# print("줄바꿈 문자\n 연습")
# print('$' * 20)


a = "파이썬 수업 진행중"
# len(a)
# print(len(a))

# print(a[5]) #업

# # 파업 이라는 글자를 출력해보자 인덱싱 + 슬라이싱
# print(a[4] + a[5] + a[0] + a[5])
# print(a[0] + a[5])

print(a[0:3])
print(a[5:-1])
print(a[5:9])

# -를 달면 역순으로 인덱스 찾아간다. 길이를 넘어가는 역순이면 인덱스 오류
print(a[-10])

# 변수[첫번째 문자 : 끝나는 문자]
# 파이썬이라는 글자를 슬라이싱 해봅시다.
print(a[0:3])
print(a[:3])

# 수업이라는 글자를 슬라이싱 해봅시다.
print(a[4:6])

# 진행중이라는 글자를 슬라이싱 해봅시다.
print(a[7:10])
print(a[7:])

b = "Pithon"
print(b[1])
# b[1] ='i'
b = "Python"
print(b)
