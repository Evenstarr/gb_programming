/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Использовать только математические операции, нельзя использовать число как строку по типу number[2])

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int a = IntInput("Введите число: ");

int GetThirdNumber(int val) {
    while (val >= 1000) val /= 10;
    return val % 10;
}

if (a > 99) {
    Console.Write($"{GetThirdNumber(a)}");    
} else {
    Console.Write($"Третьей цифры нет");    
}

// Обработку, если число не входит в Int32, не приделала, исключения не проходили. Вроде, ни в одной задаче такого не требовалось. 
