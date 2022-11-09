/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

// Про B - Отрицательные и нецелые числа к натуральным не относят (а хотелось, отрицательные степени тоже прекрасно работают при определенной доработке)
// А вот про А не написано, что оно целое
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

double DoubleInput(string message) {
    Console.Write(message);

    return Convert.ToDouble(Console.ReadLine());
}

double Pow(double a, int b) {
    double res = a;
    for (int i = 1; i < b; i++) {
        res *= a; 
    }
    return res;
}

double a = DoubleInput("Введите число A: ");
int b = IntInput("Введите число B: ");

Console.WriteLine(Pow(a, b));
