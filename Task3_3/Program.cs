/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int a = IntInput("Введите целое положительное число: ");
int b = 1;

while (b <= a) {
    Console.Write($"{Math.Pow(b, 3)} ");
    b++;
}

