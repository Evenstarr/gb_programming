/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значениями элементов массива.

[3 7 22 2 78] -> 76
*/

void PrintArray(double[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

double[] FillDoubleArray(int len, int min, int max) {
    double[] arr = new double[len]; 
    for (int i = 0; i < len; i++) {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

double FindMinMaxDifference(double[] arr) {
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < min) {
            min = arr[i];
        } else if (arr[i] > max) {
            max = arr[i];
        }
    }
    return (max - min);
}

int len = new Random().Next(0, 10);
Console.WriteLine($"Длина массива {len}");

double[] initialArr = FillDoubleArray(len, -100, 100);

PrintArray(initialArr);

Console.WriteLine($"Разница между мин и макс элементами - {FindMinMaxDifference(initialArr)}. ");
