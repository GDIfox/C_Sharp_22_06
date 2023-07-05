// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите целое число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень возведения числа A: ");
int B = int.Parse(Console.ReadLine()!);

int Stepen()
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
return result;
}

int rez = Stepen();
Console.WriteLine($"{A} в степени {B} = {rez}");