/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int num = IntInput("Введите 5значное число: ");
if (num < 10000 && num > 99999) {
    Console.WriteLine("Число не 5значное");
    return;
}

int digit, reverse = 0;
int initial = num;

while (num != 0) {
    digit = num % 10;
    reverse = reverse * 10 + digit; 
    num = num / 10;
}

if (initial == reverse) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}
