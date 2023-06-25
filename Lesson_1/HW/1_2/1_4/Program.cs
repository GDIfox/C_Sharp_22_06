// Напишите программу, которая принимает на вход три числа 
//     и выдаёт максимальное из этих чисел.


int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if (a > b & c < a)
{
    Console.WriteLine("Max = {0}", a);
}
else if (a < b & b > c)
{
    Console.WriteLine("Max = {0}", b);
}
else if (c > a & c > b)
{
    Console.WriteLine("Max = {0}", c);
}