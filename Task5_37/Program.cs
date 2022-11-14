/* 37
Найдите произведение пар чисел в одномерном массиве
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве
[1 2 3 4 5] -> [5 8 3]
[6 7 3 6] -> [36 21]
*/

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] FillArray(int len) {
    int[] arr = new int[len]; 
    for (int i = 0; i < len; i++) {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int[] MakeMultArray(int[] arr) {
    bool hasEvenNumbers = arr.Length % 2 == 0? true : false; 
    int newLen = 0;

    if (hasEvenNumbers) {
        newLen = arr.Length / 2;
    } else {
        newLen = arr.Length / 2 + 1;
    }

    int[] resArr = new int[newLen];

    for (int i = 0; i < arr.Length / 2; i++) {
        resArr[i] = arr[i] * arr[arr.Length - i - 1];
    }


    if (!hasEvenNumbers) {
        resArr[newLen - 1] = arr[newLen - 1];    
    }

    return resArr;
}

int len = new Random().Next(0, 10);
Console.WriteLine($"Длина массива {len}");

int[] initialArr = FillArray(len);

PrintArray(initialArr);

PrintArray(MakeMultArray(initialArr));
