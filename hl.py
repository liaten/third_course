def hamming_distance(string_1:str, string_2:str) -> int: 
    distance = 0
    for i in range(len(string_1)):
        if string_1[i] != string_2[i]:
            distance += 1
    return distance

def lev_dist(a, b): # функция возвращает число
    n, m = len(a), len(b)
    if n > m:
        # убедимся что n <= m, чтобы использовать минимум памяти O(min(n, m)) a - наим строка, b - наиб строка
        a, b = b, a
        n, m = m, n
    current_row = range(n + 1)  # 0 ряд - просто восходящая последовательность (одни вставки)
    for i in range(1, m + 1):
        previous_row, current_row = current_row, [i] + [0] * n
        for j in range(1, n + 1):
            add, delete, change = previous_row[j] + 1, current_row[j - 1] + 1, previous_row[j - 1]
            if a[j - 1] != b[i - 1]:
                change += 1
            current_row[j] = min(add, delete, change)
    return current_row[n]

str1 = "любопытство"
str2 = "любознательность"
output = ""
if(len(str1)!=len(str2)):
    output += "Расстояние Хэмминга вычислить невозможно\n"
else:
    output += "Расстояние Хэмминга между строкой \"%s\" и строкой \"%s\" = %s\n" % (str1, str2, hamming_distance(str1, str2))
output += "Расстояние Левенштейна между строкой \"%s\" и строкой \"%s\" = %s\n" % (str1, str2, lev_dist(str1, str2))
print(output)
