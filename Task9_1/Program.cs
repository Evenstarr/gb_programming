/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int n = IntInput("Введите n: ");
NaturalNumber(n);

void NaturalNumber(int a)
{
   if (a == 1) {
    Console.Write(a);
   } else {
      Console.Write($"{a}, ");
      NaturalNumber(a - 1);
   }
}
