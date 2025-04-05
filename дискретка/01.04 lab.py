from collections import deque

def init_matrix():
    n = int(input("Введите число строк матрицы"))
    m = int(input("Введите число столбцов матрицы"))
    matrix = [(m+1)*[-1]]
    for i in range(n):
        curr_str = [-1]
        for j in range(m):
            curr_str.append(int(input("Введите -1, если стена, иначе 0")))
        curr_str.append(-1)
        matrix.append(curr_str)
    matrix.append((m+1)*[-1])
    return matrix
def wave_algorithm(matrix, i_start, j_start, i_finish, j_finish):
    if (matrix[i_start][j_start] == -1 or matrix[i_finish][j_finish] == -1):
        return -1

    next_vertexes = deque()
    next_vertexes.append((i_start,j_start))
    while len(next_vertexes)!=0:
        i,j = next_vertexes.popleft()
        d = matrix[i][j]
        if (i,j) == (i_finish,j_finish):
            return matrix[i_finish][j_finish]
        elif matrix[i][j] == -1:
            continue
        else:
            for curr_i, curr_j in [(i+1,j), (i-1,j), (i,j-1), (i,j+1)]:
                if matrix[curr_i][curr_j] == 0 and (curr_i, curr_j) != (i_start, j_start):
                    matrix[curr_i][curr_j] = d + 1
                next_vertexes.append((curr_i, curr_j))
    return -1
