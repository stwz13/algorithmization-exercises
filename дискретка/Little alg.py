
import numpy as np
import copy

def init_matrix():
    n = int(input("Введите число строк матрицы"))
    matrix = [[i for i in range(n)]]
    begin = 1
    print("Введите -1, если вершины не связаны")
    for i in range(n):
        curr_str = [begin]
        for j in range(n):
            inp = int(input())
            if inp == - 1:
                curr_str.append(float('inf'))
            else:
                curr_str.append(inp)
        matrix.append(curr_str)
    return np.array(matrix)

def matrix_reduction(matrix):
    new_matrix = np.array(matrix)
    min_strs = np.min(new_matrix[1:, 1:], axis=1, keepdims=True)
    new_matrix[1:, 1:] -= min_strs

    min_stlbs = np.min(new_matrix[1:, 1:], axis = 0, keepdims=True)
    new_matrix[1:, 1:] -= min_stlbs

    k_reduction = np.sum(min_strs) + np.sum(min_stlbs)

    return k_reduction, new_matrix

def o_max_step(matrix):
    n = len(matrix)
    max_sum = -float('inf')
    o_max_step_coordinates = (-1, -1)
    for i in range(1,n):
        for j in range(1,n):
            if matrix[i, j] == 0:
                min_stlb_curr = float('inf')
                min_str_curr = float('inf')
                for k in range(1,n):
                    if k != i:
                        min_stlb_curr = min(min_stlb_curr, matrix[k, j])
                    if k != j:
                        min_str_curr = min(min_str_curr, matrix[i, k])
                if (max_sum <= min_stlb_curr + min_str_curr):
                    max_sum = min_stlb_curr + min_str_curr
                    o_max_step_coordinates = (i, j)

    return o_max_step_coordinates

def little_algorithm(matrix):
    matrix = np.array(matrix)
    finded_way = []
    lower_way = 0
    old_matrix = copy.copy(matrix)
    while len(matrix) != 2:
        k, matrix = matrix_reduction(matrix)
        lower_way += k
        max_o_i, max_o_j = o_max_step(matrix)
        new_vertex1 = int(matrix[max_o_i,0])
        new_vertex2 = int(matrix[0,max_o_j])
        finded_way.append((new_vertex1, new_vertex2))
        matrix = np.delete(matrix, max_o_i, axis=0)
        matrix = np.delete(matrix, max_o_j, axis=1)
        if new_vertex1 in matrix[0, :] and new_vertex2 in matrix[:,0]:
            vertex1 = np.where(matrix[0, :] == new_vertex1)[0][0]
            vertex2 = np.where(matrix[:, 0] == new_vertex2)[0][0]
            matrix[vertex2,vertex1] = float('inf')
    finded_way.append((int(matrix[1,0]), int(matrix[0,1])))

    ans_way = [finded_way[0][0], finded_way[0][1]]

    while len(ans_way) < len(finded_way):
        for element in finded_way:
            if element[0] == ans_way[-1]:
                ans_way.append(element[1])
                break

    len_way = sum(int(old_matrix[ans_way[i], ans_way[i+1]]) for i in range(len(ans_way)-1))
    return ans_way, len_way

matrix = [
    [0, 1, 2, 3, 4, 5, 6],
    [1, float('inf'), 31, 15, 19, 8, 55],
    [2, 19, float('inf'), 22, 31, 7, 35],
    [3, 25, 43, float('inf'), 53, 57, 16],
    [4, 5, 50, 49, float('inf'), 39, 9],
    [5, 24, 24, 33, 5, float('inf'), 14],
    [6, 34, 26, 6, 3, 36, float('inf')]
]
print(little_algorithm((matrix)))