// Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Crat(int num){
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else 
    {
        Console.WriteLine("No");
    }
}

int numA = int.Parse(Console.ReadLine()!);
Crat(numA);