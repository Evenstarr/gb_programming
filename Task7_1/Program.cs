/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int m = IntInput("Введите m: ");
int n = IntInput("Введите n: ");

double[,] RandomDoubleArray(int m, int n) {
    double[,] doubleArray = new double[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            doubleArray[i, j] = new Random().NextDouble() * (-20) + 10;
        }
    }

    return doubleArray;
}

void Print2DArrayDouble(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write("{0:0.00} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

Print2DArrayDouble(RandomDoubleArray(m, n));