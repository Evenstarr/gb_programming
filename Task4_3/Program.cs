/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

int[] FillArray(int len) {
    int[] arr = new int[len]; 
    for (int i = 0; i < len; i++) {
        arr[i] = new Random().Next(0, 1000);
    }
    return arr;
}

int n = IntInput("Введите длину массива: ");


PrintArray(FillArray(n));
