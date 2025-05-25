from collections import deque

def find_way(graph, begin, end, previous):
    busy_vertex = [False] * len(graph)
    queue = deque([begin])

    while queue:
        curr_vertex = queue.popleft()
        busy_vertex[curr_vertex] = True

        max_capacity = -float('inf')
        max_capacity_vertex = None

        for i in range(len(graph)):
            if not busy_vertex[i] and graph[curr_vertex][i] != 0:
                if graph[curr_vertex][i] > max_capacity:
                    max_capacity = graph[curr_vertex][i]
                    max_capacity_vertex = i

        if max_capacity_vertex is None:
            break

        previous[max_capacity_vertex] = curr_vertex
        if max_capacity_vertex == end:
            return True

        queue.append(max_capacity_vertex)

    return False


def ford_fullkerson(graph, begin, end):
    max_flow = 0
    previous = {i:-1 for i in range(len(graph))}

    while find_way(graph, begin, end, previous):
        curr_flow = float('inf')
        curr_vertex = end
        while curr_vertex != begin:
            curr_flow = min(curr_flow, graph[previous[curr_vertex]][curr_vertex])
            curr_vertex = previous[curr_vertex]
        max_flow += curr_flow

        curr_vertex = end

        while curr_vertex != begin:
            change_vertex = previous[curr_vertex]
            graph[change_vertex][curr_vertex] -= curr_flow
            graph[curr_vertex][change_vertex] += curr_flow
            curr_vertex = change_vertex

        previous = {i:-1 for i in range(len(graph))}

    return max_flow



graph = [
    [0, 10, 0, 0],
    [0, 0, 5, 0],
    [0, 0, 0, 10],
    [0, 0, 0, 0]
]

print(ford_fullkerson(graph, 0, 3))