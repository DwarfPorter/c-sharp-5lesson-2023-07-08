// Задача 3: Задайте одномерный массив из 10 
// случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int Count2Digits(int[] array)
{
    int cnt = 0;
    foreach (int item in array)
    {
        if (10 <= item && item <= 99)
        {
            cnt++;
        }
    }
    return cnt;
}

int[] array = GenerateArray(10, 1, 200);
ShowArray(array);
System.Console.WriteLine($"{Count2Digits(array)} - столько двузначныз чисел в массиве");