// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void MeanSum(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double srednearifm = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            srednearifm = Math.Round(sum / array.GetLength(0), 2);
        }
        Console.Write($"{srednearifm}; ");
        // Console.Write(srednearifm + "\t")
    }
    return;
}

Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);

// Console.Write("Введите искомое число в массиве: ");
// int argum = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] NewArray = new int[str, col];

RandomArray(NewArray);
PrintArray(NewArray);
Console.WriteLine();
MeanSum(NewArray);
