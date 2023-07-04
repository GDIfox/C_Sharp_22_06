// принимает чсило А и выдается сумма от 1 до А

int SumNum(int num)
{
    int all_sum = 0; // если есть произведение - то начинаем с 1
    for (int i = 1; i <= num; i++)
    all_sum += i;

    return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);





