from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split # Split arrays or matrices into random train and test subsets.
from numpy import concatenate
from random import randint

def euclidean_distance(data1, data2):
    distance = 0
    for i in range (len(data1) - 1):
        distance += (data1[i] - data2[i]) ** 2
    return distance**(1/2)

def get_neighbors(train, test, k):
    distances = [(train[i][-1], euclidean_distance(train[i], test))
                  for i in range (len(train))]
    distances.sort(key=lambda elem: elem[1])
    return [distances[i][0] for i in range (k)]

def prediction(neighbors):
    count = {}
    for instance in neighbors:
        if instance in count:
            count[instance] +=1
        else :
            count[instance] = 1
    target = max(count.items(), key=lambda x: x[1])[0]
    return target

def accuracy(test, test_prediction):
    correct = 0
    for i in range (len(test)):
        if test[i][-1] == test_prediction[i]:
            correct += 1
    return (correct / len(test))

iris_dataset = load_iris() # возвращает объект с несколькими полями
print(iris_dataset['DESCR'][:177]) # описание датасета
print('Виды ирисов:')
print(iris_dataset['target_names'])
print(iris_dataset['feature_names']) # характеристики каждого цветка
print('Исходные данные:')
print(iris_dataset['target']) # 0 - setosa, 1 - versicolor, 2 - virginica
print(iris_dataset['data'].shape) # всего 150 цветков, у каждого 4 измерения

# Случайно берем позицию между 60% и 80% от исходного массива
arr_len = len(iris_dataset['target'])
random_place = randint(arr_len*0.6,arr_len*0.8)
# Находим размер тестового массива
_test_size = (arr_len - random_place) / arr_len
print('test_size', _test_size)

# Заполняем тренировочный и тестовый массивы из исходного
x_train, x_test, y_train, y_test = train_test_split(iris_dataset.data[:, 2:4], 
                                                    iris_dataset['target'],
                                                    test_size=_test_size,
                                                    random_state=random_place) # random_state - для воспроизводимости

print(f'X_train shape: {x_train.shape}, y_train shape: {y_train.shape},\n'
      f'X_test shape: {x_test.shape}, y_test shape: {y_test.shape}')

x_train_concat = concatenate((x_train, y_train.reshape(x_train.shape[0], 1)), axis=1)
x_test_concat = concatenate((x_test, y_test.reshape(x_test.shape[0], 1)), axis=1)
print(f'X_train shape: {x_train_concat.shape},\n'
      f'X_test shape: {x_test_concat.shape}')

predictions = []
for x in range (len(x_test_concat)):
    neighbors = get_neighbors(x_train_concat, x_test_concat[x], k=6)
    result = prediction(neighbors)
    predictions.append(result)
    actual = x_test_concat[x][-1]
    cool = False
    if(result == actual):
        cool = True
    print(f'Предсказано {result}, На деле {actual}, {cool}') # если есть интерес посмотреть, какие конкретно прогнозы некорректны
accuracy = accuracy(x_test_concat, predictions)
print(f'Размер тренировочного массива {x_train.shape[0]}')
print(f'Размер тестируемого массива {x_test.shape[0]}')
print(f'Ошибки: {100-accuracy*100}%')