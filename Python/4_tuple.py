t1 = ()
t2 = 1,
t3 = (1,2,3)
t4 = 1,2,3
t5 = ('a', 'b', ('ab','cd'))

print(t1)
print(t2)
print(t3)
print(t4)
print(t5)

# t3[0] = 4
# del t3[0]

print(t3[2])
print(t3[1:])

print(t3 + t4)
print(t3 * 3)

# len은 length라는 뜻으로 ()안에 있는 값의 요소 수를 알려줌
print(len(t3))