
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
    matrix = np.array(matrix)
    min_strs = np.min(matrix[1:, 1:], axis=1, keepdims=True)
    matrix[1:,1:] -= min_strs

    min_stlbs = np.min(matrix[1:,1:], axis = 0, keepdims=True)
    matrix[1:, 1:] -= min_stlbs

    k_reduction = np.sum(min_strs) + np.sum(min_stlbs)

    return k_reduction

def o_max_step(matrix):
    n = len(matrix)
    max_sum = -float('inf')
    o_max_step_coordinates = (-1, -1)
    for i in range(1,n):
        for j in range(1,n):
            if matrix[i,j] == 0 and (i,j)!=(0,0):
                min_stlb_curr = float('inf')
                min_str_curr = float('inf')
                for k in range(n):
                    if (k != i): min_stlb_curr = min(min_stlb_curr, matrix[k,j])
                    if (k != j): min_str_curr = min(min_str_curr, matrix[i,k])
                if (max_sum <= min_stlb_curr + min_str_curr):
                    max_sum = min_stlb_curr + min_str_curr
                    o_max_step_coordinates = (i,j)
    return o_max_step_coordinates

def little_algorithm(matrix):
    matrix = np.array(matrix)
    finded_way = []
    lower_way = 0
    old_matrix = copy.copy(matrix)
    while len(matrix) != 2:
        lower_way += matrix_reduction(matrix)
        max_o_i, max_o_j = o_max_step(matrix)
        new_vertex1 = old_matrix[max_o_i,0]
        new_vertex2 = old_matrix[0,max_o_j]
        finded_way.append((new_vertex1, new_vertex2))
        matrix = np.delete(matrix, max_o_i, axis=0)
        matrix = np.delete(matrix, max_o_j, axis=1)
        if new_vertex1 in matrix[0, 1:] and new_vertex2 in matrix[1,0:]:
            vertex1 = matrix[:0].tolist().index(new_vertex1)
            vertex2 = matrix[0:].tolist().index(new_vertex2)
            matrix[vertex2,vertex1] = float('inf')
    ans_way = [finded_way[0][0]]
    for i in range(1, len(finded_way)):
        if finded_way[i][0] == ans_way[-1]:
            ans_way.append(finded_way[i][1])
        elif finded_way[i][1] == ans_way[0]:
            ans_way.insert(0, finded_way[0])
        else:
            for j in range(len(ans_way) - 1):
                if finded_way[i][0] == ans_way[i] and finded_way[i][1] == ans_way[i+1]:
                    ans_way.insert(i, finded_way[0])
    len_way = sum(old_matrix[ans_way[i], ans_way[i+1]] for i in range(len(ans_way)-1))
    return ans_way, len_way



matrix = init_matrix()
way, len_way = little_algorithm(matrix)