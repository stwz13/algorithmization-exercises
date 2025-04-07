#1 алгоритм



graph=[]
print("Введите число вершин графа")
n = int(input())
for i in range(n):
    str = []
    for j in range(n):
        print(f"Введите элемент {i} строки и {j} столбца\n"
              f"Если вершины {i} и {j} не соединены, введите -")
        str.append(int(input()))
    graph.append(str)

#алгоритм Прима
free_vertexes1 = [x for x in range(1, n)]
tree1 = [0]
ans1 = 0
while len(free_vertexes1)!=0:
    new_vertex = -1
    mn = float('inf')
    for i in range(len(tree1)):
        for j in range(n-1):
            if (graph[i][j]!='-' and graph[i][j] < mn):
                new_vertex = j
                mn = graph[i][j]
    free_vertexes1.remove(new_vertex)
    tree1.append(new_vertex)
    ans1+=mn
print(ans1)
#алгоритм Краскала
free_vertexes2 = []

ans2 = 0
for i in range(n):
    for j in range(i+1,n):
        if graph[i][j] != '-':
            free_vertexes2.append((i,j,graph[i][j]))
free_vertexes2 = sorted(free_vertexes2, key = lambda x: x[2])[1::-1]
tree2 = [free_vertexes2[0][1], free_vertexes2[0][2]]
for i in range(len(free_vertexes2)):
    if free_vertexes2[i][0] not in tree2 and free_vertexes2[i][1] not in tree2:
        tree2.append(free_vertexes2[i][0])
        tree2.append(free_vertexes2[i][1])
        ans2+=free_vertexes2[i][2]
print(ans2)
















