// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A");
double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B");
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);
double z2 = double.Parse(Console.ReadLine()!);

double Distance3D ()
{
    double RazKvX = Math.Pow(x2-x1, 2);
    double RazKvY = Math.Pow(y2-y1, 2);
    double RazKvZ = Math.Pow(z2-z1, 2);
    double result = Math.Sqrt(RazKvX + RazKvY + RazKvZ);    
    Console.WriteLine("=>> " + Math.Round(result, 2));
    return result;
}

Distance3D();