//  Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

void RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 50);
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

void ChangeRow(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0, j], array[array.GetLength(0) - 1, j]) = (
            array[array.GetLength(0) - 1, j],
            array[0, j]
        );
    }
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
ChangeRow(NewArray);
PrintArray(NewArray);
