﻿// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintNumber(int M, int N)
{
    if (N < M)
        return;

    PrintNumber(M, N - 2);
    Console.Write($"{N} ");
}
PrintNumber(1, 20);
