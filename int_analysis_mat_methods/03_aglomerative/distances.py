# ЭТОТ ФАЙЛ НАПИСАН В КАЧЕСТВЕ БИБЛИОТЕКИ К ФАЙЛУ ALGO_CLUSTER
from asyncio.windows_events import NULL


def min_item_in_list_by_id(list1, list2, id):
    if(list1[id]<list2[id]):
        return list1[id]
    return list2[id]

def min_distance(dist):
    min_dist = 1000
    min_c = []
    for e in dist:
        for el in e:
            if(el<min_dist):
                min_dist = el
                min_c = [dist.index(e),e.index(el)]
    min_c.sort()
    return min_c

def move_to_top(dist,min_c):
    dist[0],dist[min_c[0]],dist[1],dist[min_c[1]] = dist[min_c[0]],dist[0],dist[min_c[1]],dist[1]

def move_to_start(dist,min_c):
    for i in range(len(dist)):
        (dist[i])[0],(dist[i])[min_c[0]],(dist[i])[1],(dist[i])[min_c[1]] = (dist[i])[min_c[0]], (dist[i])[0], (dist[i])[min_c[1]], (dist[i])[1]

def print_array(array, classes=None):
    if classes is None:
        for element in array:
            print(element)
    else:
        for i in range(len(array)):
            print(array[i], classes[i])
    print()

def create_smallest_list(lists,new_len):
    smallest_list = [1000]
    for i in range(new_len):
        smallest_list.append(min_item_in_list_by_id(lists[0],lists[1],i))
    return smallest_list

def upgrade_dist(dist, smallest_list, new_len, save_dist):
    dist = [smallest_list] + [0]*new_len
    for i in range(new_len):
        dist[i+1] = [smallest_list[i+1]] + [e for e in save_dist[i]]
    return dist

def distances(dist_input, classes_input, N):
    dist = dist_input
    classes = classes_input
    errors_classes = 0
    operations_classes = 0
    while(len(dist)>N):
        min_c = min_distance(dist) # Находим минимальное число
        if(classes[min_c[0]]!=classes[min_c[1]]):
            errors_classes +=1 # Считаем ошибки - случаи, когда происходит слияние разных классов
        classes[0],classes[min_c[0]] = classes[min_c[0]],classes[0]
        classes.pop(min_c[1]) # Удаляю из списка классов оставшийся
        operations_classes +=1 # Считаем операции с классами
        move_to_top(dist,min_c) # Двигаем наверх строчки с минимумами
        move_to_start(dist,min_c) # Меняем местами 2 первых столбца и столбцы с минимумами
        new_len = len(dist)-2 # Считаем размер финального массива
        save_dist = [e[-new_len:] for e in dist[-new_len:]] # Сохраняем строчки, которые будут в новом массиве
        lists = [(dist[e])[-new_len:] for e in [0,1]]   # Берем с конца первых двух строчек необходимое количество элементов для поиска наименьших значений
        smallest_list = create_smallest_list(lists,new_len) # Создаём первую строчку/столбец нового массива
        dist = upgrade_dist(dist,smallest_list,new_len,save_dist) # Обновляем старый массив новыми данными
    error_percent = errors_classes/operations_classes*100
    print('Процент слияний разных классов =',error_percent,'%')
    return dist

# Для тестирования работы алгоритма:
dist = [
        [1000,17,21,31,23],
        [17,1000,30,34,21],
        [21,30,1000,28,39],
        [31,34,28,1000,43],
        [23,21,39,43,1000],
    ]
classes = [
    'Iris-setosa',
    'Iris-setosa',
    'Iris-versicolor',
    'Iris-versicolor',
    'Iris-virginica'
]

dist = distances(dist,classes,3)
print_array(dist)
print_array(classes)