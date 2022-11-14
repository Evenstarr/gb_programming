/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int SumOdds(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (i % 2 == 1) {
            count += arr[i];
        }
    }
    return count;
}

int len = new Random().Next(0, 10);
Console.WriteLine($"Длина массива {len}");

int[] initialArr = FillArray(len, -100, 100);

PrintArray(initialArr);

Console.WriteLine($"Сумма элементов на нечетных позициях - {SumOdds(initialArr)}. ");

