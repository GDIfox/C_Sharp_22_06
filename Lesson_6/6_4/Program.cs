// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

void RandomArray(int[,] array)
{
    //    int[,] array = new int[,];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10, 100);
            //            Console.Write($"{array[i, j]} ");
        }
        //    Console.WriteLine();
        //    return  array;
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
