// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RandomArray(double[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //          array[i, j] = random.NextDouble()*100;  // вариант только с положительными числами получается
            array[i, j] = Math.Round(random.Next(-100, 100) * 0.1, 1);
        }
    }
    // return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //System.Console.Write("{0, 6:F2}", array[i, j]); // вывод с двумя знаками после запятой (от 0 до 1)
            System.Console.Write($"{array[i, j], 5}");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine();
double[,] NewArray = new double[str, col];

RandomArray(NewArray);
PrintArray(NewArray);
