import numpy as np;
n = 3;
m = 4;
A = np.array([20, 15, 25]);
B = np.array([13, 17, 19, 11]);
C = np.array([[6, 5, 2, 1], [3, 5, 4, 2], [5, 3, 6, 3]]);
X = np.array([[0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0]]);
#Метод на Северозападния ъгъл
i = 0;
j = 0;
while True:
    if A[i] == B[j] and i == n - 1 and j == m - 1:
        X[i][j] = A[i];
        break;
    elif A[i] > B[j]:
        X[i][j] = B[j];
        A[i] = A[i] - B[j];
        j = j + 1;
    elif A[i] < B[j]:
        X[i][j] = A[i];
        B[j] = B[j] - A[i];
        i = i + 1;
    elif A[i] == B[j]:
        X[i][j] = A[i];
        i = i + 1;
        j = j + 1;
print(X, '\n');
#Обходни линии
s = 0;
while True:
    Empty_Cells = [];
    for i in range(n*m-(n+m-1)):
        Empty_Cells.append(0);
    Full_Cells = [];
    for i in range(n+m-1):
        Full_Cells.append(0);
    p = 0;
    q = 0;
    for i in range(n):
        for j in range(m):
            if X[i][j] == 0:
                del Empty_Cells[p];
                Empty_Cells.insert(p, [i, j]);
                p = p + 1;
            elif X[i][j] != 0:
                del Full_Cells[q];
                Full_Cells.insert(q, [i, j]);
                q = q + 1;
    Loop = [];
    for k in range(len(Empty_Cells)):
        Loop.append([]);
    for k in range(len(Empty_Cells)):
        i0 = Empty_Cells[k][0];
        j0 = Empty_Cells[k][1];
        Edge_k = [i0, j0];
        Loop[k].append(Edge_k);
        for l in range(len(Full_Cells)):
            if j0 == Full_Cells[l][1]:
                Edge_k = Full_Cells[l];
                Loop[k].append(Edge_k);
                i1 = Full_Cells[l][0];
                break;
        for l in range(len(Full_Cells)):
            if i1 == Full_Cells[l][0] and j0 != Full_Cells[l][1]:
                Edge_k = Full_Cells[l];
                Loop[k].append(Edge_k);
                j1 = Full_Cells[l][1];
                break;
        for l in range(len(Full_Cells)):
            if [i0, j1] == Full_Cells[l]:
                Edge_k = [i0, j1];
                Loop[k].append(Edge_k);
                break;
        if len(Loop[k]) == 2:
            del Loop[k][1];
        if len(Loop[k]) < 4:
            for l in range(len(Full_Cells)):
                if j1 == Full_Cells[l][1] and i1 != Full_Cells[l][0]:
                    Edge_k = Full_Cells[l];
                    Loop[k].append(Edge_k);
                    i2 = Full_Cells[l][0];
                    break;
            for l in range(len(Full_Cells)):
                if i2 == Full_Cells[l][0] and j1 != Full_Cells[l][1]:
                    Edge_k = Full_Cells[l];
                    Loop[k].append(Edge_k);
                    j2 = Full_Cells[l][1];
                    break;
            for l in range(len(Full_Cells)):
                if [i0, j2] == Full_Cells[l]:
                    Edge_k = [i0, j2];
                    Loop[k].append(Edge_k);
                    break;
        if k == len(Empty_Cells) - 1 and s == 0:
            s = s+ 1;
            Loop[k] = [];
            i0 = Empty_Cells[k][0];
            j0 = Empty_Cells[k][1];
            Edge_k = [i0, j0];
            Loop[k].append(Edge_k);
            for l in reversed(range(len(Full_Cells))):
                if j0 == Full_Cells[l][1]:
                    Edge_k = Full_Cells[l];
                    Loop[k].append(Edge_k);
                    i1 = Full_Cells[l][0];
                    break;
            for l in reversed(range(len(Full_Cells))):
                if i1 == Full_Cells[l][0] and j0 != Full_Cells[l][1]:
                    Edge_k = Full_Cells[l];
                    Loop[k].append(Edge_k);
                    j1 = Full_Cells[l][1];
                    break;
            for l in reversed(range(len(Full_Cells))):
                if [i0, j1] == Full_Cells[l]:
                    Edge_k = [i0, j1];
                    Loop[k].append(Edge_k);
                    break;
    Q = 10**5;
    u = [];
    for i in range(n):
        u.append(Q);
    v = [];
    for i in range(m):
        v.append(Q);
    del u[Full_Cells[0][0]];
    u.insert(Full_Cells[0][0], 0);
    for i in range(len(Full_Cells)):
        if u[Full_Cells[i][0]] != Q and v[Full_Cells[i][1]] == Q:
            del v[Full_Cells[i][1]];
            v.insert(Full_Cells[i][1], C[Full_Cells[i][0]][Full_Cells[i][1]] - u[Full_Cells[i][0]]);
        elif v[Full_Cells[i][1]] != Q and u[Full_Cells[i][0]] == Q:
            del u[Full_Cells[i][0]];
            u.insert(Full_Cells[i][0], C[Full_Cells[i][0]][Full_Cells[i][1]] - v[Full_Cells[i][1]]);
    for i in range(len(Full_Cells)):
        if u[Full_Cells[i][0]] != Q and v[Full_Cells[i][1]] == Q:
            del v[Full_Cells[i][1]];
            v.insert(Full_Cells[i][1], C[Full_Cells[i][0]][Full_Cells[i][1]] - u[Full_Cells[i][0]]);
        elif v[Full_Cells[i][1]] != Q and u[Full_Cells[i][0]] == Q:
            del u[Full_Cells[i][0]];
            u.insert(Full_Cells[i][0], C[Full_Cells[i][0]][Full_Cells[i][1]] - v[Full_Cells[i][1]]);
    Delta = [];
    delta_k = 0;
    for i in range(len(Empty_Cells)):
        delta_k = u[Empty_Cells[i][0]] + v[Empty_Cells[i][1]] - C[Empty_Cells[i][0]][Empty_Cells[i][0]];
        Delta.append(delta_k);
        delta_k = 0;
        max_elem = Delta[0];
    for i in range(len(Delta)):
        if max_elem < Delta[i]:
            max_elem = Delta[i];
    if max_elem <= 0:
        break;
    index_max_elem = Delta.index(max_elem);
    min_x = [];
    for j in range(len(Loop[index_max_elem])):
        k1 = Loop[index_max_elem][j][0];
        k2 = Loop[index_max_elem][j][1];
        if j % 2 != 0:
            min_x.append(X[k1][k2]);
    for j in range(len(Loop[index_max_elem])):
        k1 = Loop[index_max_elem][j][0];
        k2 = Loop[index_max_elem][j][1];
        if j % 2 == 0:
            X[k1][k2] = X[k1][k2] + min(min_x);
        else:
            X[k1][k2] = X[k1][k2] - min(min_x);
print(Delta, '\n');
print(X, '\n');
F = 0;
for i in range(n):
    for j in range(m):
        if X[i][j] != 0:
            F = F + X[i][j]*C[i][j];
print(F);
