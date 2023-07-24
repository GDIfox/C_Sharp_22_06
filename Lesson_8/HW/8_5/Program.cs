// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
}

int[] SummaString(int[,] array)
{
    int[] sumelements = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumelements[i] += array[i, j];
        }
    }
    return sumelements;
}

void FindMinimum(int[] array)
{
    int minimum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minimum])
        {
            minimum = i;
        }
    }
    Console.WriteLine($"Сумма элементов = {array[minimum]}, строка -> {minimum + 1}");
}

Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] NewArray = new int[str, col];

RandomArray(NewArray);
PrintArray(NewArray);
Console.WriteLine();
int[] Array = SummaString(NewArray);
FindMinimum(Array);
