# s1 = set([1,2,3])
# print(s1)

# s2 = set("Hello")
# print(s2)

# l1 = list(s1)
# print(l1)
# print(l1[0])

# t1 = tuple(s1)
# print(t1)
# print(t1[0])


s3 = set([1,2,3,4,5,6])
s4 = set([4,5,6,7,8,9])

print(s3 & s4) # 교집합 기호 &
print(s3.intersection(s4))
print(s4.intersection(s3))

print(s3 | s4) # 합집합 기호 |
print(s3.union(s4))
print(s4.union(s3))

print(s3 - s4)
print(s4 - s3)
print(s3.difference(s4)) # 1,2,3
print(s4.difference(s3)) # 7,8,9

s3.add(7)
print(s3)

s3.update([10,11,12])
print(s3)

s3.remove(1)
print(s3)

s3.difference_update([3,4,5]) 
print(s3)

s3 -= {1,2}
print(s3)

