// Задайте двумерный массив.
// Найдите сумму элементов главной диагонали.
//    https://4apple.org/summa-diagonalnyh-jelementov-matricy/
//    https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C
  кому  Все
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }

}
void EvenElement(int[,] arr)
{
    int sum = 0;
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        for (int i = 1; i < arr.GetLength(0); i += 2)
        {
            for (int j = 0; j < arr.GetLength(1); j += 2)
            {
                if (i == j)
                {
                  sum = sum + arr[i, j];
                }
            // arr[i, j] *= arr[i, j];
            }
        }
    }
    Console.Write($"{sum}");
}



Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
EvenElement(matrix);
PrintArray(matrix);