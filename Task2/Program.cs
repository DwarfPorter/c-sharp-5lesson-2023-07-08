// Задача 2: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

bool ExistsItem(int[] array, int num)
{
    foreach (int item in array)
    {
        if (item == num)
        {
            return true;
        }
    }
    return false;
}


int[] array = GenerateArray(12, -9, 9);
ShowArray(array);
int num = ReadInt("Введите число для поиска");
if (ExistsItem(array, num))
{
    System.Console.WriteLine("Число присутствует");
}
else
{
    System.Console.WriteLine("Число отсутствует");
}