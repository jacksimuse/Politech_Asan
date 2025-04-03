money = True

if money:
    print("택시를 타라")
else:
    print("걸어가라")


if 1 > 2 :
    print("1이 2보다 크다")
else:
    print("1이 2보다 크지않다")


# != 를 사용해서 값을 비교하여 if문 안의 코드가 작동하도록 만들어봅시다
a = 10
b = 1111111


if a != b :
    print("%d이 %d 크다" %(a, b))
else:
    print("%d이 %d보다 크지않다" %(a, b))


c = True
d = False

# 조건1 or 조건2
if c or d:
    print("c와 d중 하나만 참이어도 참")
# 조건1 and 조건2
if c and d:
    print("c와 d가 모두 참")
# not 조건1
if not c:
    print("c의 부정형")

e = [1,2,3]
f = (4,5,6)

if 1 in e:
    print("e 리스트 안에 숫자 1 있음")
else:
    print("e 리스트 안에 숫자 1 없음")

if 1 not in f:
    print("f 튜플 안에 숫자 1 없음")
else:
    print("f 튜플 안에 숫자 1 있음")


# 문자열을 만들어서 안에 '문자'가 있는지 확인해보자
if 'h' not in "hello":
    print("hello 문자열 안에 h 없음")
elif 'h' in "hello":
    print("hello 문자열 안에 h 있음")
else:
    pass


score = 70
message = "success" if score >= 60 else "failure"

print(message)


# if else elif / 비교연산자( >,<, !=, >=, <=) / or, and, not / in, not in

# not (1 > 2) -> True


# 비교연산자 2개 or / (조건1) or (조건2)
# not in 리스트 / 

if (10 < 11) or (3.14 != 3):
    print("참입니다")
else:
    print("거짓입니다")

if 10 not in [ 1,2,3,4,5]:
    print("참입니다")
else:
    print("거짓입니다")


# 1. if문에 문자열을 가지고 조건을 완성해봅시다 / print "문자열이 채워져있습니다"
# 2. elif문에 딕셔너리 넣고 조건을 완성해봅시다/ print "한쌍이 채워져있습니다"
# 3. else 거짓만 남았습니다

if "":
    print("문자열이 채워져있습니다")
elif {1:"한쌍"}:
    print("한쌍이 채워져있습니다")
else:
    print("거짓만 남았습니다")
