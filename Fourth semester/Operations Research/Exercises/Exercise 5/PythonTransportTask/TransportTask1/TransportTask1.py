import numpy as np

n = 3
m = 4
A = [20, 15, 25]
B = [13, 17, 19, 11]
C = [[6, 5, 2, 1], [3, 5, 4, 2], [5, 3, 6, 3]]
X = [[0, 0, 0, 0],[0, 0, 0, 0],[0, 0, 0, 0]]

# Метод на северозападния ъгъл
i = 0
j = 0

while True:
    if A[i] == B[j] and i == n-1 and j == m-1:
        X[i][j] = A[i]
        break
    elif A[i] > B[j]:
        X[i][j] = B[j]
        A[i] = A[i]-B[j]
        j = j+1
    elif A[i] < B[j]:
        X[i][j] = A[i]
        B[j] = B[j]-A[i]
        i = i+1
    elif A[i] == B[j]:
        X[i][j] = A[i]
        i = i+1
        j = j+1

print(np.array(X))
s = 0
while True:
    empty_cells = []
    for i in range(n*m-(n+m-1)):
        empty_cells.append(0)
    full_cells = []
    for i in range(n+m-1):
        full_cells.append(0)
    p = 0
    q = 0
    for i in range(n):
        for j in range(m):
            if X[i][j] == 0:
                empty_cells[p] = [i, j]
                p = p + 1
            elif X[i][j] != 0:
                full_cells[q] = [i, j]
                q = q + 1

    Loop = []
    for k in range(len(empty_cells)):
        Loop.append([])
    for k in range(len(empty_cells)):
        i0 = empty_cells[k][0]
        j0 = empty_cells[k][1]
        Edge_k = [i0, j0]
        Loop[k].append(Edge_k)

        for r in range(len(full_cells)):
            if j0 == full_cells[r][1]:
                Edge_k = full_cells[r]
                Loop[k].append(Edge_k)
                i1 = full_cells[r][0]
                break
        for r in range(len(full_cells)):
            if i1 == full_cells[r][0] and j0 != full_cells[r][1]:
                Edge_k = full_cells[r]
                Loop[k].append(Edge_k)
                j1 = full_cells[r][1]
                break
        for r in range(len(full_cells)):
            if [i0, j1] == full_cells[r]:
                Edge_k = [i0, j1]
                Loop[k].append(Edge_k)
                break
        if len(Loop[k]) == 2:
            del Loop[k][1]
        if len(Loop[k]) < 4:
            for r in range(len(full_cells)):
                if j1 == full_cells[r][1] and i1 != full_cells[r][0]:
                    Edge_k = full_cells[r]
                    Loop[k].append(Edge_k)
                    i2 = full_cells[r][0]
                    break
            for r in range(len(full_cells)):
                if i2 == full_cells[r][0] and j1 != full_cells[r][1]:
                    Edge_k = full_cells[r]
                    Loop[k].append(Edge_k)
                    j2 = full_cells[r][1]
                    break
            for r in range(len(full_cells)):
                if [i0, j2] == full_cells[r]:
                    Edge_k = [i0, j2]
                    Loop[k].append(Edge_k)
                    break

        if k == len(empty_cells) - 1 and s == 0:
            s = s + 1
            Loop[k] = []
            i0 = empty_cells[k][0]
            j0 = empty_cells[k][1]
            Edge_k = [i0, j0]
            Loop[k] = Edge_k
            for r in range(len(full_cells), 0):
                if j0 == full_cells[r][1]:
                    Edge_k = full_cells[r]
                    Loop[k].append(Edge_k)
                    i1 = full_cells[r][0]
                    break
            for r in range(len(full_cells), 0):
                if i1 == full_cells[r][0] and j0 != full_cells[r][1]:
                    Edge_k = full_cells[r]
                    Loop[k].append(Edge_k)
                    j1 = full_cells[r][1]
                    break
            for r in range(len(full_cells), 0):
                if [i0, j1] == full_cells[r]:
                    Edge_k = [i0, j1]
                    Loop[k].append(Edge_k)
                    break

    Delta = []
    sum_c = 0
    for i in range(len(Loop)):
        for j in range(len(Loop[i])):
            k1 = Loop[i][j][0]
            k2 = Loop[i][j][1]
            if j % 2 == 0:
                sum_c = sum_c - C[k1][k2]
            else:
                sum_c = sum_c + C[k1][k2]
            Delta.append(sum_c)
            sum_c = 0

    max_elem = Delta[0]

    for i in range(len(Delta)):
        if max_elem < Delta[i]:
            max_elem =  Delta[i]
        if max_elem <= 0:
            break

    index_max_elem = Delta.index(max_elem)
    min_x = []

    for j in range(len(Loop[index_max_elem])):
        k1 = Loop[index_max_elem][j][0]
        k2 = Loop[index_max_elem][j][1]
        if j % 2 != 0:
            min_x[j] = X[k1][k2]
    for j in range(len(Loop[index_max_elem])):
        k1 = Loop[index_max_elem][j][0]
        k2 = Loop[index_max_elem][j][1]
        if j % 2 == 0:
            X[k1][k2] = X[k1][k2] + min(min_x)
        else:
            X[k1][k2] = X[k1][k2] - min(min_x)

print(np.array(Delta))
print(np.array(X))
F = 0
for i in range(n):
    for j in range(m):
        if X[i][j] != 0:
            F = F + X[i][j] * C[i][j]
print(F)
