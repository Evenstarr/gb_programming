/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

1 2 3, 4, -5 5 6 -> 1 
*/


////// НА НЕКОРРЕКТНЫЙ ВВОД, НАПРИМЕР, БУКВЕННЫЙ, НЕ РАБОТАЕТ. Я знаю, что сделать, чтобы работало, но исключения нельзя использовать. 
// Думаю, в C# есть какой-нибудь typeof, но его, наверное, тоже нельзя) 


Console.Write("Введите числа через запятую: ");

string? line = Console.ReadLine();

if (line == String.Empty) {
    Console.WriteLine("Нужно что-нибудь ввести");
    return;
} 

int count = 0; 

string? tmp = String.Empty;

for (int i = 0; i < line.Length; i++) {
    tmp = String.Empty;

    while (line[i] != ',') {
        if (i < line.Length - 1) {
            if (line[i] != ' ') {
                tmp += line[i];
            }
            i++;
        } else { 
            tmp += line[i];
            break;
        }
    } 
    if (Convert.ToInt32(tmp) > 0) {
        count++;
    }
}

Console.WriteLine($"Число положительных элементов - {count}");
