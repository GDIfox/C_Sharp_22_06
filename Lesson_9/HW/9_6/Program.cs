// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int PrintNumber(int M, int N)
{
    if (M <= N)
    {
        return N + PrintNumber(M, N - 1);
    }
    // else if (M > N)
    // {
    //     return N + PrintNumber(M, N + 1);
    // }

    return 0;
}
Console.WriteLine($"{PrintNumber(4, 8)}");
