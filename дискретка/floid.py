def init_graph():
    graph=[[]]
    print("введите порядок графа")
    n = int(input())
    for i in range(n):
        curr = []
        for j in range(n):
            if i==j:
                curr[j] = 0
            else:
                print("введите 1, если i и j связаны, иначе 0")
                ans = int(input())
                if ans == 1:
                    curr[j] = int(input())
                else:
                    curr[j] = float('inf')
        graph.append(curr)
    return graph
def floid(graph):
    copy_graph = graph.copy()
    for k in range(len(copy_graph)):
        for i in range(len(copy_graph)):
            for j in range(len(copy_graph)):
                if copy_graph[i][j] > copy_graph[i][k] + copy_graph[k][j]:
                    copy_graph[i][j] = copy_graph[i][k] + copy_graph[k][j]
    print(i for i in range(len(copy_graph)))
    for i in range(len(copy_graph)):
        print(f"{i} ")
        for j in range(len(copy_graph)):
            print(f"{graph[i][j]} ")
    return copy_graph