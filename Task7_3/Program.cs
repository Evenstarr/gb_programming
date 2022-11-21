/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void ColAvg(int[,] arr) {
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++) {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++) {
            sum += arr[i, j];
        }
        double average = (double)sum/arr.GetLength(0);
        Console.Write("{0:0.00}; ", average);
    }
}


int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] arr = RandomIntArray(m, n);
Print2DArrayInt(arr);

ColAvg(arr);
