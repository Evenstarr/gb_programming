/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] FillArray(int len, int min, int max) {
    int[] arr = new int[len]; 
    for (int i = 0; i < len; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int CountEvens(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

int len = new Random().Next(0, 10);
Console.WriteLine($"Длина массива {len}");

int[] initialArr = FillArray(len, 100, 999);

PrintArray(initialArr);

Console.WriteLine($"Количество четных чисел в массиве - {CountEvens(initialArr)}");

