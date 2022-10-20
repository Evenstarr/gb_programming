/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int x1 = IntInput("Введите х1: ");
int y1 = IntInput("Введите y1: ");
int z1 = IntInput("Введите z1: ");

int x2 = IntInput("Введите х2: ");
int y2 = IntInput("Введите y2: ");
int z2 = IntInput("Введите z2: ");

Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
