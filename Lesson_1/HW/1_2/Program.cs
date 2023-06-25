// Напишите программу, которая на вход принимает два числа и выдаёт, 
//    какое число большее, а какое меньшее.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
    Console.WriteLine("Max = {0}", b);
}
else
{
    Console.WriteLine("Max = {0}", a);
}

