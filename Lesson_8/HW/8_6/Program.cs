// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
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

int[,] ArrayMultiplication(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayMulti = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    if (arrayOne.GetLength(0) != arrayTwo.GetLength(0))
    {
        if (arrayOne.GetLength(1) != arrayTwo.GetLength(1))
        {
            return arrayMulti;
        }
    }
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            arrayMulti[i, j] = arrayOne[i, j] * arrayTwo[i, j];
        }
    }
    return arrayMulti;
}
Console.Write("Введите число строк Первого массива : ");
int strOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов Первого массива: ");
int colOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите число строк Второго массива: ");
int strTwo = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов Второго массива: ");
int colTwo = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] NewArrayOne = new int[strOne, colOne];
Console.WriteLine();
int[,] NewArrayTwo = new int[strTwo, colTwo];

int[,] ranArrayOne = RandomArray(NewArrayOne);
PrintArray(ranArrayOne);
Console.WriteLine();
int[,] ranArrayTwo = RandomArray(NewArrayTwo);
PrintArray(ranArrayTwo);
Console.WriteLine();

int[,] ArrayResult = ArrayMultiplication(ranArrayOne, ranArrayTwo);
PrintArray(ArrayResult);
