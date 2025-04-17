def count_comp(graph):
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
    return ans
def ost_tree(graph):
    n = len(graph)
    free_vertexes = [x for x in range(1, n)]
    list_edge = []
    while len(free_vertexes) != 0:
        new_vertex = -1
        mn = float('inf')
        for i in range(len(list_edge)):
            for j in range(n - 1):
                if (graph[i][j] != '-' and graph[i][j] < mn):
                    new_vertex = j
                    mn = graph[i][j]
                    list_edge.append([i,j])
        free_vertexes.remove(new_vertex)
        return list(list_edge)
def ost_tree_matrix(ost_tree):
    ost_tree_matrix = []
    for i in range(n):
        for j in range(n):
            if [i,j] in ost_tree:
                ost_tree_matrix[i][j] = 1
            else: ost_tree_matrix[i][j] = 0
graph = []
ans = []


print("Введите число вершин графа")
n = int(input())
for i in range(n):
    str = []
    for j in range(n):
        print(f"Введите элемент {i} строки и {j} столбца")
        str.append(int(input()))
    graph.append(str)


k = count_comp(graph)
ost_tree = ost_tree(graph)



for edge in ost_tree:
    copy_tree = ost_tree.copy().remove(edge)
    curr_tree_matrix = ost_tree_matrix(copy_tree)
    if count_comp(curr_tree_matrix) > k:
        ans.append(edge)
print(ans)





