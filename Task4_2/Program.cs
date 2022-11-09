/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int n = IntInput("Введите число: ");

int sum = 0;

while (n > 0) {
    sum += n % 10; 
    n /= 10;
}

Console.WriteLine($"Сумма цифр введенного числа = {sum}");
