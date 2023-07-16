// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //          array[i, j] = random.NextDouble()*100;  // вариант только с положительными числами получается
            array[i, j] = random.Next(0, 50);
        }
    }
    // return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // с позиции
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //System.Console.Write("{0, 6:F2}", array[i, j]); // вывод с двумя знаками после запятой (от 0 до 1)
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
}

string FindNum(int[,] array, int arg)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == arg)
            {
                return $"{arg} -> такое число есть";
            }
        }
    }
    return $"{arg} -> такого числа нет";
}

Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое число в массиве: ");
int argum = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] NewArray = new int[str, col];

RandomArray(NewArray);
PrintArray(NewArray);
Console.WriteLine();
System.Console.WriteLine(FindNum(NewArray, argum));
