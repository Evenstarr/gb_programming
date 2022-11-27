/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
1 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void MinSum(int[,] arr) {
    int minSum = 0;
    int minIndex = 1;

    for (int j = 0; j < arr.GetLength(1); j++) {
        minSum += arr[0,j];
    }

    for (int i = 0; i < arr.GetLength(0); i++) {
        int sumTmp = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {
            sumTmp += arr[i,j];
        }
        if (sumTmp < minSum) {
            minSum = sumTmp;
            minIndex = i + 1; // человеческий вывод с 1
        }
    }

    Console.WriteLine($"{minIndex} строка");
}

int m = 4;
int n = 3;
int[,] arr = RandomIntArray(m, n);
Print2DArrayInt(arr);
Console.WriteLine();
MinSum(arr);