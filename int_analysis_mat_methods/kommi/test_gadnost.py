with open('bays.tsp', 'r') as file:
    data = file.readlines()
graph = []
for line in data:
    a = [int(s) for s in line.strip().split() if s.isdigit()]
    graph.append(a)

n_graph = len(graph)

def min_scan (v, l_v):
    min = 100000
    min_n = 0
    for j in l_v:
        if graph[v][j]< min:
            min_n = j
            min = graph[v][j]
    return min_n

for i in range(0,n_graph):
    vert = [vу for vу in range(0,n_graph)]
    v_current = i
    path = [v_current]
    len_path = 0

    for j in range(0,(n_graph-1)):
        vert.remove(v_current)
        s = min_scan(v_current,vert)
        path += [s]
        len_path += graph[v_current][s]
        v_current = s

    path += [i]
    len_path = len_path + graph[v_current][i]
    print('path',path,len_path)
