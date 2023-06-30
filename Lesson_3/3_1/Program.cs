// Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!);

void Quarters(int quarter)
{
    if (querter > 4 && quarter > 1) System.Console.WriteLine("Error");
    else if (querter == 1) System.Console.WriteLine("x > 0 && y > 0");
    else if (querter == 2) System.Console.WriteLine("x < 0 && y > 0");
    else if (querter == 3) System.Console.WriteLine("x < 0 && y < 0");
    else if (querter == 4) System.Console.WriteLine("x > 0 && y < 0");
}

Quarters(quarter);