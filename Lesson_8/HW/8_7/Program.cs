// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

int[,] RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 20);
        }
    }
    return array;
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
    int minimumNums = array[0, 0];
    int[] ints = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimumNums > array[i, j])
            {
                minimumNums = array[i, j];
                ints[0] = i;
                ints[1] = j;
            }
        }
        //        Console.WriteLine(array[ints[0], ints[1]]);
    }
    Console.WriteLine($"Минимальный элемент = {array[ints[0], ints[1]]}");
    return ints;
}

void RemuveLineCol(int[,] array, int[] minElements)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElements[0] == i || minElements[1] == j)
                continue;
            // if (minElements[0] == i)
            // {
            //     if (minElements[1] == j)
            //     {
            //         continue;
            //     }
            else
                Console.Write($"{array[i, j], 4}");

            //Console.WriteLine();
        }
        Console.WriteLine();
    }
    //    Console.WriteLine();
}

Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] NewArray = new int[str, col];

int[,] ranArrayOne = RandomArray(NewArray);
PrintArray(ranArrayOne);
Console.WriteLine();

int[] ArrayRemuveNew = SummaString(ranArrayOne);
RemuveLineCol(ranArrayOne, ArrayRemuveNew);
