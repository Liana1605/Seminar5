﻿// Задайте одномерный массив из 123 случайных чисел. Найдите кол-во
// элементов массива, значение которых лежат в отрезке [10,99]
// [5,18,123,6,2] ->1
// [1,2,3,6,2] ->0
// [10,11,12,13,14] ->5

int[] arrRand(int len) // функция заполнения массива произв длины случайными числами
{
    int[] a = new int [len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 1000);
    }
    return a;
}

void arrPrint(int[] a) // функция вывода массива
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int[] arr = arrRand(123);
arrPrint(arr);
int sum = 0;
foreach (var i in arr)
{
    if(i > 9 && i < 100) sum ++;
}
Console.WriteLine($"Количество элементов масссива - {sum}");