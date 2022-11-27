/*
Доп. задача 61*: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int size = IntInput("Введите размер: ");
MakeTriange(size);

void MakeTriange(int size) {
    int val = 1;
    for(int i = 0; i < size; i++) {
        for(int blank = 1; blank <= size - i; blank++)
            Console.Write(" ");
            for(int j = 0; j <= i; j++) {
                if (j == 0||i == 0)
                    val = 1;
                else
                    val = val * (i-j+1) / j;
                Console.Write(val + " ");
            }
    Console.WriteLine();
    }
}