/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

void Print2DArrayInt(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write("{0:00} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int n = IntInput("Введите размер матрицы: ");

int current = 1;
int size = n * n;
int i = 0;
int j = 0;
int rest = 0;
int[,] numbers = new int[n, n];
while (current <= size) {
    while (i < (n - rest)) {
        numbers[i, j] = current;
        current++;
        i++;
    } 
    i--; 
    j++;
    while (j < (n - rest)) {
        numbers[i, j] = current;
        current++;
        j++;
    }
    j--; 
    i--;
    while (i >= rest) {
        numbers[i, j] = current;
        current++;
        i--;
    }
    i++; 
    j--; 
    rest++;
    while (j >= rest) {
        numbers[i, j] = current;
        current++;
        j--;
    }
    j++;
    i++;
}

Print2DArrayInt(numbers);