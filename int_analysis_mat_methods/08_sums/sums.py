n = int(input())
arr = [1 for i in range(n)]
out = ""
out += str(arr)
while(len(arr)>1):
    # Обнуляем коэффициенты
    min, min_p, sum = arr[0], 0, 0
    # Находим минимум
    for i in range(len(arr)-1):
        if(arr[i]<min):
            min = arr[i]
            min_p = i
    # print('min',min,'min_p',min_p) # для проверки
    # Создаем промежуточный массив методом прибавления к минимуму 1 и вычитания 1 с конца
    for i in range(len(arr)):
        if(i==min_p):
            arr[i] += 1
            arr[-1] -= 1
            for i in range(i+1,len(arr)):
                sum+=arr[i]
            break
    # print(arr,'sum',sum) # для проверки
    # Создаем новый массив
    arr = [arr[i] for i in range(0,min_p+1)] + [1 for i in range(sum)]
    out += "\n" + str(arr)
print(out)