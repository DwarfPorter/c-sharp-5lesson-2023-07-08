// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

// len - длина массива
// min - минимальная граница диапазона значений в массиве
// max - максимальная граница диапазона значений в массиве
int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// Вывод на экран массива
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SumPositive(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if (item > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if (item < 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumExt(int[] array, int sign = 1)
{
    int sum = 0;
    foreach(int item in array)
    {
        if (item * sign > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int[] array = GenerateArray(12, -9, 9);
ShowArray(array);
System.Console.WriteLine($"Сумма положительных значений = {SumPositive(array)}");
System.Console.WriteLine($"Сумма отрицательных значений = {SumNegative(array)}");
System.Console.WriteLine($"Сумма 2 положительных значений = {SumExt(array)}");
System.Console.WriteLine($"Сумма 2 отрицательных значений = {SumExt(array, -1)}");
