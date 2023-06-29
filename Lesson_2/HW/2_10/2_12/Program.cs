// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 
int FunThreeNum(int number)
{
    int result = -1; // цифра показывающая отсутствие её
    if (number >= 100)
    {
        if (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}
int number = int.Parse(Console.ReadLine()!);
int result = FunThreeNum(number);
 
Console.WriteLine("Третье число = " + result);
