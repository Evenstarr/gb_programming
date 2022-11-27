/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] RandomIntArray(int m, int n) {
    int[,] intArray = new int[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            intArray[i, j] = new Random().Next(0, 50);
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

int[,] SortRows(int[,] arr) {
    int tmp;
    for (int i = 0; i < arr.GetLength(0); i++) {
        tmp = 0;
        for (int j = 0; j < arr.GetLength(1) - 1; j++) {
            for (int k = j + 1; k < arr.GetLength(1); k++) {
                if (arr[i, j] < arr[i, k]) {
                    tmp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = tmp;
                }
            }            
        }
    }
    return arr;
}

int m = 4;
int n = 3;
int[,] arr = RandomIntArray(m, n);
Print2DArrayInt(arr);
Console.WriteLine();
Print2DArrayInt(SortRows(arr));