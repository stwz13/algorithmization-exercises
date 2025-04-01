def init_matrix():
    n = int(input("Введите число строк матрицы"))
    m = int(input("Введите число столбцов матрицы"))
    matrix = [m*[-1]]
    for i in range(n):
        curr_str = [-1]
        for j in range(m):
            curr_str.append(int(input("Введите -1, если стена, иначе 0")))
        curr_str.append(-1)
        matrix.append(curr_str)
    matrix.append(m*[-1])
    return matrix
def walve(matrix, i, j, d):
    curr_vertexes = [(i, j-1), (i, j+1), (i-1, j), (i+1, j)]
    result = False
    for x, y in curr_vertexes:
        if matrix[x][y] == 0:
            matrix[x][y] = d + 1
            result = True
    return result
def min_way(matrix, i_start, j_start, i_finish, j_finish):
    d = 0
    walve(matrix, i_start, j_start, d)
    while True:
        for i in range(1, len(matrix) - 1):
            for j in range(1, len(matrix[i]) - 1):
                if matrix[i][j] not in [0, -1]:
                    result = walve(matrix, i, j, d)
                    if matrix[i_finish][j_finish] != 0:
                        return matrix[i_finish][j_finish]
                    elif result: d+=1
                    else: break




