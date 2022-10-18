/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Использовать только математические операции, нельзя использовать число как строку по типу number[1])

456 -> 5
782 -> 8
918 -> 1*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int a = IntInput("Введите трехзначное число: ");

if (a < 100 || a > 999) {
    Console.Write("Число не трехзначное");
    return;
}

int num = a / 10 % 10; 
Console.WriteLine($"{num}");

