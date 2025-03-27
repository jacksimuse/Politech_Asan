dic = {'이름':'최재훈', '전화번호':'010-7569-9066', "생일" : "0306"}

print(dic)
# dic의 키 모음집을 만들고 싶다.
# '이름' , '전화번호', '생일'

print(dic['전화번호'])

high = {'월': 'plc', '화':'C#', '수':'시퀀스', '목':'파이썬'}
print(high)

# dictionary 변수에 새로운 값 추가하기기
# 변수[키] = 값

print('금' in high) # in 이라는 기능을 사용해서 변수안에 키가 있는지 확인하고 새로 추가를 해주었음 
high['금'] = '캐드' # True 였으면 딕셔너리에서 중복 키는 맨 뒤에만 인정되기 때문

print(high)

day = {'요일' : ['월','화','수','목','금']}
print(day)
print(day['요일'])

# 변수 명 'rainbow' 에 '무지개'가 키, ['빨', '주', '노', '초','파','남','보'] 값
rainbow = {'무지개' : ['빨', '주', '노', '초','파','남','보']}
print(rainbow)
# rainbow 딕셔너리에 (다른색 : 검정) 한쌍 추가하기
rainbow['다른색'] = '검정'
print(rainbow)

# 변수명 all / 1 : '값' / 'key' : 2 / '자료형' : [3, 'value']
# all 이라는 변수에 'dic' : '사전' 추가하기
all = {1:'값', 'key':2, '자료형' : [3, 'value'] }
print(all)
all['dic'] = '사전'
print(all)


# del을 사용하려면 해당 값을 지우는 개념이라 list나 dictionary에는 접근이 필요함
# list와 dictionary 접근으로는 변수[인덱스], 변수[키]
# del 변수[인덱스], 변수[키]

del all['dic']
print(all)

# list에 1,2,3,4,5를 넣고 인덱스 2에 있는 값을 지워주세요
a = [1,2,3,4,5]
print(a)
print(len(a))
del a[2]
print(a)
print(len(a))

# 리스트 10,20,30,40,50
# 딕셔너리 10 : '10' / 20 : '20' / 30 : '30' / 40 : '40'/ 50 : '50'
# 각 변수에서 20과 40을 출력하시오

a = [10,20,30,40,50]
b = {10 : '10', 20 : '20', 30 : '30', 40 : '40', 50 : '50'}

# b의 key모음집 
# 10 , 20, 30, 40, 50


print(a[1], a[3])
print(b[20], b[40])

# 딕셔너리 주의사항
# 키가 중복일 경우 맨 뒤에 쌍만 인정
c = {1:'a', 1:'b', 1: 'c'}
print(c)

# 키로 list는 불가 -> 가변적이어서 안됨
# 키로 tuple은 가능 -> 불변적이어서 가능
# d = {[1,2] : 'hi'}
# print(d)

e = {'한국' : '폴리텍', '하이테크' : '반도체장비'}

# 변수.keys() 변수의 key값들을 list로 모아줌
# dict_keys(키 모음) 로 반환됨
# print(e.keys())


# 리스트로 사용하기 위해서는 list(변수.keys())로 형변환 해주면됨
print(list(e.keys()))


f = list(e.keys()) # f = ['한국', '하이테크']
print(f[0]) # f[0]

# values() 값들의 모음집
print(list(e.values()))

# items() dictionary와 내용은 같지만 한 쌍씩 묶어줌
print(e)
print(list(e.items()))
g = list(e.items())
print(g[0])

# 1교시 : 국어 / 2교시 : 수학 / 3교시 : 영어 / 4교시 : 사회 / 5교시 : 과학
# keys(), values(), items()
# list로 형변환 한거를 다른 변수에 담고 각자 2번 인덱스에 있는 것을 출력해봅시다.

subject = {'1교시' : '국어', '2교시' : '수학',  '3교시' : '영어',  '4교시' : '사회', '5교시' : '과학' }
print(subject.keys())
print(subject.values())
print(subject.items())

sub1 = list(subject.keys()) 
print(sub1[2]) # 3교시
sub2 = list(subject.values())
print(sub2[2])  # 영어
sub3 = list(subject.items()) 
print(sub3[2]) # (3교시, 영어) tuple
print(sub3[2][1]) # 영어 -> 리스트 안에 튜플 속의 값에 접근함

# 변수를 만들때는 자료형 이름을 사용하지 않는다. 왜냐면 컴파이러가 오해를 한다.
# list = [1,2,3,4,5]

seclist = [1,2,3,[4,5,6]]
print(seclist[2])
print(seclist[3]) # [4,5,6]
print(seclist[3][1]) # 5

# subject.clear()
print(subject)



# [] 리스트, () 튜플, {} 딕셔너리
# 리스트는 가변성이 있고 여러 함수를 사용해서 자유롭게 이용가능
# 튜플 리스트와 비슷하지만 수정, 삭제 안됨, 변동이 있으면 안되는 데이터에 사용
# 딕셔너리 가변성 있고 여러 함수를 사용하지만 값에 대한 접근은 순서가 없다. 즉 인덱스가 없고 키로 작용이 된다.


# print(subject['0교시']) # 변수[키] 했을 때 없는 키면 오류
print(subject.get('0교시')) # 변수.get(키) 했을 때 없는 키면 None을 반환
print(subject.get('0교시', '수업없음')) # 키가 없을 때 원하는 값을 반환 하도록 할 수 있음

print('0교시' in subject)
print('1교시' in subject)
