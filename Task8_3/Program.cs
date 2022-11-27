/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] RandomIntArray(int m, int n) {
    int[,] intArray = new int[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            intArray[i, j] = new Random().Next(0, 10);
        }
    }

    return intArray;
}

void Print2DArrayInt(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMult(int[,] arr1, int[,] arr2) {
    int[,] resMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++) {
        for (int j = 0; j < arr2.GetLength(1); j++) {
            for (int r = 0; r < arr1.GetLength(1); r++) {
                resMatrix[i, j] += arr1[i, r]*arr2[r, j];
            }
        }
    }
    return resMatrix;
}

int l = 4;
int m = 5;
int n = 3;


int[,] matrix1 = RandomIntArray(l, m);
int[,] matrix2 = RandomIntArray(m, n);

/*int l = 2;
int m = 2;
int n = 2;
int[,] matrix1 = {{2, 4}, {3, 2}};
int[,] matrix2 = {{3, 4}, {3, 3}};*/

Print2DArrayInt(matrix1);
Console.WriteLine();
Print2DArrayInt(matrix2);
Console.WriteLine();
Print2DArrayInt(MatrixMult(matrix1, matrix2));
