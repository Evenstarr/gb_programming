﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int n = 1;

while (n <= a) {
    if (n % 2 == 0) {
        Console.Write(n + " ");
    }
    n++;
}