import time

def min_scan (graph, v, l_v):
    min = 100000
    min_n = 0
    for j in l_v:
        if graph[v][j]< min:
            min_n = j
            min = graph[v][j]
    return min_n

def get_graph_from_file(filename):
    with open(filename, 'r') as file:
        data = file.readlines()
    graph = []
    for line in data:
        a = [int(s) for s in line.strip().split() if s.isdigit()]
        graph.append(a)
    return graph

def main():
    graph = get_graph_from_file('bays.tsp')
    graph_size = len(graph)
    lenpaths = []
    paths = []
    
    for i in range(0,graph_size):

        vert = [item for item in range(0,graph_size)]
        current = i
        path = [current]
        len_path = 0

        for j in range(0,(graph_size-1)):

            vert.remove(current)
            s = min_scan(graph, current,vert)
            path += [s]
            len_path += graph[current][s]
            current = s

        # path += [i]
        len_path = len_path + graph[current][i]
        lenpaths.append(len_path)
        paths.append(path)
        # print('path',path,len_path)

    min_lenpath = min(lenpaths)
    print('min path', paths[lenpaths.index(min_lenpath)], min_lenpath)

if __name__ == "__main__":
    start_time = time.time() # сохранение времени начала выполнения
    main() # выполнение кода
    print("time of execution: %s seconds" %abs (time.time() - start_time)) # вычисление времени выполнения