def ford_bellman(graph, curr_vertex):
    n = len(graph)
    l = [float('inf')] * n
    l[curr_vertex] = 0
    for i in range(1, n-1):
        l[i] = 0
        curr = float('inf')
        for j in range(n):
            l[i] = min(curr, l[j] + graph[i][j])
    print(l)