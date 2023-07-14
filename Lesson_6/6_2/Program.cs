// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string BinaryNumber(int num)
{
    string number = string.Empty;

    for (; num != 0; num /= 2)
    {
        number = num % 2 + number;
    }
    return number;
}

System.Console.WriteLine(BinaryNumber(12));
