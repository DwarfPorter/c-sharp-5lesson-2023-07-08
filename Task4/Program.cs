// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] MultiPairs(int[] array)
{
    int[] pairs = new int[array.Length / 2 + array.Length % 2];
    pairs[pairs.Length - 1] = array[pairs.Length - 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        pairs[i] = array[i] * array[array.Length - i - 1];
    }
    
    return pairs;
}

int len = ReadInt("Размер массива > ");
int[] array = GenerateArray(len, 1, 5);
ShowArray(array);
System.Console.WriteLine();
ShowArray(MultiPairs(array));
