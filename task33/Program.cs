// Задайте массив. Напишите программу, которая определяет 
// присутствует ли заданое число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// -3; массив [6,7,19,345,3] -> да

int[] arrRand(int len) // функция заполнения массива произв длины случайными числами
{
    int[] a = new int [len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 10);
    }
    return a;
}

void arrPrint(int[] a) // функция вывода массива
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int [] arr = arrRand(5);
arrPrint(arr);

Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = false;
foreach (var a in arr)
{
    if (a == num)
    {
        result = true;
        break;
    }
}
if (result) Console.WriteLine($"Число {num} - есть в массиве");
else Console.WriteLine($"Число {num} - нет в массиве");