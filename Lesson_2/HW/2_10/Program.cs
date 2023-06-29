// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int ThreeNum(int num)
{
   int num2 = num % 100;
   int num3 = num2 / 10;
   return num3;
}

int RunNum = new Random().Next(100, 1000);
int result = ThreeNum(RunNum);
Console.WriteLine(RunNum + " -> " + result);