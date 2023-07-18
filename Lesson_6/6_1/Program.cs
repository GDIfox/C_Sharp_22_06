// Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < a + b)
        return true;
    else
        return false;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine(Triangle(a, b, c));
