/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int m = IntInput("Введите m: ");
int n = IntInput("Введите n: ");

Console.WriteLine(Sum(m, n));

int Sum(int m, int n) {
    if (m == n) {
        return m;
    } else {
        return n + Sum(m, n - 1);
    }    
}
