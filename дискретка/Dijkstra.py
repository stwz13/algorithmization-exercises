#ввод матрицы весов графа
graph=[]
n = int(input()) #порядок графа
for i in range(n):
    str_matrix = []
    for j in range(n):
        str_matrix.append(int(input()))
    graph.append(str_matrix)

begin = int(input())
end = int(input())


#алгоритм Дейкстры
ans = float('inf')
vertexes = [float('inf') for x in range(n)]
flag_vertexes = [False]*n
vertexes[begin] = 0
while not all(flag_vertexes):
    curr_min = float('inf')
    curr_min_vertex = -1
    for i in range(n):
        if graph[begin][i] != 0 and flag_vertexes[i] != True:
            if graph[begin][i] < vertexes[i]: vertexes[i] = graph[begin][i]
            if vertexes[i] < curr_min:
                curr_min = vertexes[i]
                curr_min_vertex = i
    if curr_min_vertex == -1:
        print("Граф не связный")
        break
    flag_vertexes[begin] = True
    begin = curr_min_vertex
    if flag_vertexes[end] == True:
        ans = vertexes[end]
        break
print(ans)