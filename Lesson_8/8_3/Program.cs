// Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php

// void RandomArray(int[,] array)
// {
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 50);
//         }
//     }
// }


Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FriqDic(int[,] matrix)
{
    int[] friq = new int[max + 1];

    foreach (int i in matrix)
    {
        friq[i] += 1;
    }
    return friq;
}

void PrintMass(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.WriteLine($"{i} - {array[i]} ");
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[] NewArray = FriqDic(matrix);
PrintMass(NewArray);
