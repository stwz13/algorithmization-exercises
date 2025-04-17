# 2 алгоритм
graph = []

print("Введите число вершин графа")
n = int(input())
for i in range(n):
    str = []
    for j in range(n):

        print(f"Введите элемент {i} строки и {j} столбца")
        str.append(int(input()))
    graph.append(str)

n = 1
vertexes = [[0, 1]]
for i in range(1, len(graph)):
    vertexes.append([i, 0])
    for j in range(i):
        if graph[i][j] == 1:
            if vertexes[i][1] == 0:
                vertexes[i][1] = vertexes[j][1]
            if vertexes[i][1] != 0:
                vertexes[j][1] = min(vertexes[i][1], vertexes[j][1])
    if vertexes[i][1] == 0:
        n += 1
        vertexes[i][1] = n
ans = len(set(vertexes[i][1] for i in range(len(graph))))
print(ans)