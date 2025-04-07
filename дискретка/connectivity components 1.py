#1 алгоритм



graph=[]
print("Введите число вершин графа")
n = int(input())
for i in range(n):
    str = []
    for j in range(n):
        print(f"Введите элемент {i} строки и {j} столбца")
        str.append(int(input()))
    graph.append(str)


b = [True]*len(graph)
ans = []
for i in range(len(graph)):
    if b[i]:
        curr = [i]
        b[i] = False
        for j in range(len(graph)):
            if graph[i][j]==1:
                b[j] = False
                curr.append(j)
        for k in curr:
            for m in range(len(graph)):
                if b[m] and graph[k][m] == 1:
                    b[m] = False
                    curr.append(m)
        ans.append(curr)
print((ans))