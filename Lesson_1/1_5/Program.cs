// Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

int a = int.Parse(Console.ReadLine()!); //-6
int count = -a; //6
Console.WriteLine(count);
while (count != a)
{
    if (a > 0)
        count++; // count = count + 1
    else
        count--; // count = count - 1   
    Console.WriteLine(count);
    //    count++; // count = count + 1
}

