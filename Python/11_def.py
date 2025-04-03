# 반환값 있고 매개변수 있음
def add(a,b):
    result = a + b
    return result

# print(add(1,2)) # 3을 출력

# 반환값 있고 매개변수 없음
def say():
    return 'Hi'

# print(say())


# 반환값 없고 매개변수 있음
# def mul(a, b):
#     print("%d x %d = %d" %(a, b, a*b))

# mul(1,2)

# 반환값 없고 매개변수 없음
# def school():
#     print('폴리텍')

# school()


# 1. 반환없고 매개변수 없음 함수
# def nothing():
#     a = 1
# nothing()
# # 2. 반환없고 매개변수 있음 함수
# def nothing2(aa, bb):
#     aa = 1
#     bb = aa
# nothing2(1,2)
# # 3. 반환있고 매개변수 없음 함수
# def something():
#     return "something"
# print(something())
# # 4. 반환있고 매개변수 있음 함수
# def something2(aaa, bbb):
#     return aaa / bbb
# print(something2(10, 2))

def add_many(*args):
    result = 0
    for i in args:
        result += i
    return result

#print(add_many(1,2,3,4,5,6))


def add_mul(operator, *args):
    if operator == '+':
        result = 0
        for i in args:
            result += i 
    elif operator == '*':
        result = 1
        for i in args:
            result *= i
    return result

# print(add_mul('+', 5,6))
# print(add_mul('+', 5,6,10,15))
# print(add_mul('*', 5,6,10,15))
# print(add_mul('*', 5,6))


# *매개변수는 여러가지 인자를 받는 매개변수이므로 맨 앞에 위치할 경우 단순 ','로는 구분하기 어렵다
# 구분되는 매개변수에는 직접 값을 입력해줌 ex) much = 3
def add_much(*args, much):
    result = 0
    for i in args:
        result += i
    result += much
    return result


print(add_much(1,2,3,4,5, much=3))

# def keyword(**kw):
#     print(kw)

# keyword(name = '최재훈', school = 'polytech', clsses = '7교시', hours = 3)

# # 반환값이 없는 함수를 출력할 경우 None
# print(keyword(name = '최재훈', school = 'polytech', clsses = '7교시', hours = 3))


# **키워드 매개변수는 맨 앞에 올 수 없다.
# 딕셔너리로 변환이 되서 구분을 할 수 없다.
def keyword(word, **kw):
    print(kw)
    return word

print(keyword(123, name = '최재훈', school = 'polytech', clsses = '7교시', hours = 3))


# return에 여러값이 들어가니 튜플 한 묶음으로 반환해줌
def add_and_mul(a,b):
    return a+b, a*b, a/b

print(add_and_mul(1,2))
# 변수1, 변수2 = 함수호출 -> 반환 값이 여러개이면 각각 변수에 담아줌
result1, result2, result3 = add_and_mul(1,2)

print(result1)
print(result2)
print(result3)