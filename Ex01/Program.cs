// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

// Не совсем понятно условие задачи на прием чисел от пользователя
// В примере задачи скорее всего опечатка  1, -7, 567, 89, 223 -> 3 
// Решил задачу через принятие чисел от пользователя в массив и далее работа с ним через циклы.  

void PrintResult(int[] arr, int num)
{
    for (int i = 0; i < arr.Length - 1; i++)
    Console.Write($"{arr[i]}, ");
    Console.Write($"{arr[arr.Length - 1]}  ->  {num} (числа(ел) больше 0 Вы ввели)");
}

int SumPlus(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
            sum++;
    return sum;
}

int[] InputArr(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число под номером {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
// Ввод чисел пользователем.
int[] array = InputArr("Введите общее количество чисел, которые будете вводить: ");

// Проверка массива и выборка введеных чисел на "положительность" (больше 0). 
int plusNumber = SumPlus(array);

// Печать введеных пользователем чисел и вывод количества положительных чисел
PrintResult(array, plusNumber);