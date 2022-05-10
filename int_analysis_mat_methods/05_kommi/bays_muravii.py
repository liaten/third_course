# Муравьиный алгоритм Пестерев Владислав
import numpy as np
import random as rd
from time import time

def lengthCal(antPath,distances_array):         # Рассчитать расстояния
    length = [] # Список расстояний
    dis = 0     # Расстояние
    for i in range(len(antPath)):
        for j in range(len(antPath[i]) - 1):
            dis += distances_array[antPath[i][j]][antPath[i][j + 1]]
        dis += distances_array[antPath[i][-1]][antPath[i][0]]
        length.append(dis)
        dis = 0
    return length

def get_graph_from_file(filename):  # Получаем граф из файла
    with open(filename, 'r') as file:
        data = file.readlines()
    graph = []
    for line in data:
        arr = [int(item) for item in line.strip().split() if item.isdigit()]
        graph.append(arr)
    return np.array(graph)

def main():

    distances_array = get_graph_from_file('bays.tsp') # Список всех расстояний между пунктами
    antNum = distances_array.shape[0]-1                   # Количество муравьёв (начальное значение - размер списка расстояний)
    alpha = 1                     # Фактор важности феромона (альфа)
    beta = 8                      # Фактор важности эвристической функции (бета)
    pheEvaRate = 0.6              # Скорость испарения феромона в промежутке [0;1]
    cityNum = distances_array.shape[0]
    pheromone = np.ones((cityNum,cityNum))                   # Феромоновая матрица
    heuristic = 1 / (np.eye(cityNum) + distances_array) - np.eye(cityNum)       # Матрица эвристической информации, дубль 1 / дизмат

    for iter in range(300):
        antPath = np.zeros((antNum, cityNum)).astype(int) - 1   # Путь муравья
        firstCity = [i for i in range(antNum)]
        rd.shuffle(firstCity)          # Случайное назначение начального города для каждого муравья
        unvisted = []   # Непосещённые города
        p = []
        pAccum = 0

        for i in range(len(antPath)-1):
            antPath[i][0] = firstCity[i]

        for i in range(len(antPath[0]) - 1):       # Постепенное обновление следующего города, в который приходит каждый муравей
            for j in range(len(antPath)):
                # проверяем пройденные города
                for k in range(cityNum):
                    if k not in antPath[j]:
                        unvisted.append(k)
                # Считаем накопленное кол-во феромонов
                for m in unvisted:
                    pAccum += pheromone [antPath [j][i] ] [m] ** alpha * heuristic [antPath [j][i] ] [m] ** beta
                # Создаём список всех феромонов
                for n in unvisted:
                    p.append(pheromone [antPath [j][i] ] [n] ** alpha * heuristic [antPath [j][i] ] [n] ** beta / pAccum)
                roulette = np.array(p).cumsum()               # Создание рулетки через сумму значений списка
                r = rd.uniform(min(roulette), max(roulette)) # Получаем случайное число в зависимости от округления
                for x in range(len(roulette)):
                    if roulette[x] >= r:                      # Использование метода рулетки для выбора следующего города
                        antPath[j][i + 1] = unvisted[x]
                        break
                unvisted = []
                p = []
                pAccum = 0
        pheromone = (1 - pheEvaRate) * pheromone            # Испаряем феромон
        length = lengthCal(antPath,distances_array)
        for i in range(len(antPath)):
            for j in range(len(antPath[i]) - 1):
                pheromone[antPath[i][j]][antPath[i][j + 1]] += 1 / length[i]     # Обновление феромона
            pheromone[antPath[i][-1]][antPath[i][0]] += 1 / length[i]

    minlen = min(length)
    print("min path:", antPath[length.index(minlen)], minlen)

if __name__ == "__main__":
    start_time = time() # сохранение времени начала выполнения
    main() # выполнение кода
    print("time of execution: %s seconds" %abs (time() - start_time)) # вычисление времени выполнения