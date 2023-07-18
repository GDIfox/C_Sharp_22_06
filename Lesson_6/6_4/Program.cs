// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

void RandomArray(int[,] array)
{
    Random rand = new Random();
    int[,] copy = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10, 100);
            Console.Write($"{array[i, j]} ");

            for (int o = 0; o < array.GetLength(0); o++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    copy[o, l] = array[i, j];
                    Console.Write($"{copy[o, l]} ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] massive = new int[3, 4];

//PrintArray(massive);
RandomArray(massive);
Console.WriteLine("");
PrintArray(massive);
