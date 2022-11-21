/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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

void CheckNumber(int[, ] arr, int pos) {
    int firstPos = pos / 10;
    int secondPos = pos % 10;
    
    if (firstPos < arr.GetLength(0) && secondPos < arr.GetLength(1)) {
        Console.WriteLine($"Значение элемента - {arr[firstPos, secondPos]}");
    } else {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int m = 8;
int n = 9;

int[, ] arr = RandomIntArray(m, n);
Print2DArrayInt(arr);

Console.Write("Введите позицию элемента: первая цифра - номер строки, вторая - столбца: ");
string strVal = String.Empty;
strVal = Console.ReadLine();

int number = 0;

if (!Int32.TryParse(strVal, out number)) {
    Console.WriteLine("Не число");
    return;
}
    

CheckNumber(arr, number);