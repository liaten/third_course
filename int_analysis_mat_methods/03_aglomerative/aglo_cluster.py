from math import sqrt
import numpy as np
from openpyxl import load_workbook

wb = load_workbook(filename = 'irisy.xlsx')
# l, r - рабочие пространства

l = wb['l']
iris_coordinates = []
iris_classes = []
for i in range(2,122):
    length = l.cell(row=i,column=3).value
    width = l.cell(row=i,column=4).value
    iris_class = l.cell(row=i,column=5).value
    len_width = [length, width, iris_class]
    iris_coordinates.append(len_width)
    iris_classes.append(iris_class)
iris_classes = set(iris_classes)
iris_size = len(iris_coordinates)
distances = [0]*iris_size
minimum = 1000.0
maximum = 0.0
for i in range(iris_size):
    distances[i] = [0] * iris_size
for i in range(iris_size):
    il1 = iris_coordinates[i][0] # длина 1го ириса
    iw1 = iris_coordinates[i][1] # ширина 1го ириса
    for j in range(iris_size):
        il2 = iris_coordinates[j][0] # длина 2го ириса
        iw2 = iris_coordinates[j][1] # ширина 2го ириса
        distance = sqrt(((il1 - il2) ** 2) + ((iw1 - iw2) ** 2)) # попарное расстояние между ирисами
        if(distance < minimum):
            minimum = distance
        if(distance>maximum):
            maximum = distance
        if(i==j):
            distances[i][j] = 100
        else:
            distances[i][j] = distance
    disti = np.array(distances[i])
    print(disti)

# Убираем все возможные повторения
while(True):
    minimum = 100
    maximum = 0
    # print(len_dist)
    for i in range(len(distances)-1):
        for j in range(len(distances)-1):
            if(distances[i][j] < minimum):
                minimum = distances[i][j]
    # print('min',minimum,'max',maximum)
    i_saved = []
    for i in range(len(distances)-1):
        for j in range(len(distances)-1):
            if(distances[i][j]==minimum):
                i_saved.append(i)
                i_saved.append(j)
                for k in range(len(distances)):
                    if(distances[i_saved[1]][k]<distances[i_saved[0]][k]):
                        distances[i_saved[0]][k] = distances[i_saved[1]][k]
                        distances[k][i_saved[0]] = distances[k][i_saved[1]]
                del distances[i_saved[1]]
                for k in range(len(distances)-1):
                    del distances[k][i_saved[1]]
                break

# Берём пару ближайших кластеров, и склеиваем их по минимумам
# while(len(distances)>4):
#     minimum = 100
#     maximum = 0
#     len_dist = len(distances)
#     for i in range(len_dist):
#         for j in range(len_dist):
#             if(distances[i][j] < minimum):
#                 minimum = distances[i][j]
#                 i_saved = i
#                 # print(i)
#                 # print(distances[i])
