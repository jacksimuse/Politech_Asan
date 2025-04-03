# return의 다른 생김새
# 함수 내에서 return을 만나면 값이 있으면 반환하고 없으면 함수 탈출
def say_nick(nick):
    if nick == '바보':
        return
    print("나의 별명은 %s 입니다." %nick)

say_nick('수업')
say_nick('보바')
say_nick('비보')
say_nick('바보')

def say_myself(name, age, man = True):
    print("나의 이름은 %s 입니다." %name)
    print("나이는 %d 입니다." %age)
    if man:
        print("남자입니다.")
    else:
        print("여자입니다")

# say_myself('최재훈', 20)
# say_myself('최재훈', 20, False)




# def test(a):
#     a += 1 
#     return a

# a = test(a)
# print(a)

a = 1

def test2():
    global a
    a += 1

test2()
# print(a)

# 함수이름 = lambda 매개변수1, 매개변수2, ... : 실행문
add = lambda b, c : b + c
print(add(3,4))


# 매개변수를 여러개 받는 함수 만들고,  global로 변수에 값 넣어주기
# return 값 2개짜리 만들기
apple = 0
def multi(*fruits):
    global apple
    
    for i in fruits:
        apple += i
    
    return apple, apple + 5

print(multi(123, 456))
result1, result2 = multi(123, 456)
print(result1)
print(result2)