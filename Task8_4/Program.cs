/*
Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int IntInput(string message) {
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}

int[,,] IntArray(int m, int n, int l) {
    int[] randomNumbers = new int[m*n*l];
    int value = 10;
    int[,,] intArray = new int[m, n, l];

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = value++;   
    }

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        int randomIndex = new Random().Next(0, randomNumbers.Length);
        int temp = randomNumbers[randomIndex];
        randomNumbers[randomIndex] = randomNumbers[i];
        randomNumbers[i] = temp;
    }

    int randomNumberIndex = 0;
    for (int i = 0; i < intArray.GetLength(0); i++)
        {
        for (int j = 0; j < intArray.GetLength(1); j++)
            {   
            for (int k = 0; k < intArray.GetLength(2); k++)
                {
                intArray[i,j,k] = randomNumbers[randomNumberIndex++];
            }
        }
    }

    return intArray;
}

void Print3DArrayInt(int[,,] arr) {
    for (int i = 0; i < arr.GetLength(2); i++) {
        for (int j = 0; j < arr.GetLength(0); j++) {
            for (int k = 0; k < arr.GetLength(1); k++) {       
                Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

int m = IntInput("Введите количество глубину: ");
int n = IntInput("Введите количество строк: ");
int l = IntInput("Введите столбцов: ");

if (m*n*l > 90) {
    Console.WriteLine("Неповторяющийся массив такого размера невозможен");
    return;
}

Print3DArrayInt(IntArray(m, n, l));
