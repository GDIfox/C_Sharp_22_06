// Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2


Console.WriteLine("Введите число");

int Count(int num)
{
    int result = 0;
    for (int i = 1; num != 0; i++)
    {
        num /= 10;
        result = i;  
    }
return result;  
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(Count(A));


// с произведением

// int SumNum(int num)
// {
//     int all_sum = 1;
//     for (int i = 1; i <= num; i++)
//         all_sum = all_sum*i;

//     return all_sum;
// }

// int A = int.Parse(Console.ReadLine()!);
// int result = SumNum(A);
// Console.WriteLine(result);