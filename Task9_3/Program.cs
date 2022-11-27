/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int m = IntInput("Введите m: ");
int n = IntInput("Введите n: ");

if (m < 0 || n < 0) {
    Console.WriteLine("Нужны неотрицательные числа");
    return;
}
Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0 && m > 0) {
        return Akkerman(m - 1, 1);
    } else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
