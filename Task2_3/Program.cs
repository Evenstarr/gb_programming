/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int a = IntInput("Введите число от 1 до 7: ");

if (a > 7 || a < 1) {
    Console.WriteLine("Нужно было число от 1 до 7!");
    return;
}

if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5 )
    Console.Write("Нет");
else
    Console.Write("Да");
