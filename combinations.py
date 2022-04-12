import itertools
nums = [1,2,2,4]

print("Сочетания")
i=0
itemlist = set(itertools.combinations(nums, len(nums)-1))
for item in itemlist:
    i+=1
    print(i,".",item)
    
print("Перестановки")
i=0
itemlist = set(itertools.permutations(nums, len(nums)))
for item in itemlist:
    i+=1
    print(i,".",item)

print("Декартово произведение")
i=0
nums_vars = itertools.product(nums, repeat=len(nums))
for var in nums_vars:
    i+=1
    print(i,".",var)

print("Сочетания с перестановками")
i=0
nums_vars = itertools.combinations_with_replacement(nums,len(nums))
for var in nums_vars:
    i+=1
    print(i,".",item)
