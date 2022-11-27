/*
Доп. задача 55**: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. Решить НЕ используя второй массив
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

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

void TransMatrix(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int k = 0; k < i; k++) {
            int tmp = arr[i, k];
            arr[i, k] = arr[k, i];
            arr[k, i] = tmp;
        }
    }
    Print2DArrayInt(arr);
}


int m = IntInput("Введите m: ");
int n = IntInput("Введите n: ");

if (m != n) {
    Console.WriteLine("Этот алгоритм работает только на квадратных матрицах.");
    return;
}
int[,] arr = RandomIntArray(m, n);
Print2DArrayInt(arr);
Console.WriteLine();
TransMatrix(arr);
