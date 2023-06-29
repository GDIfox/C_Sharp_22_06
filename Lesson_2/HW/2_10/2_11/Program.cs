// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int DelTwoNum(int number)
{
    // int num1 = num / 100;
    // int num3 = num % 10;
    var stroka = number.ToString();
    number = int.Parse(stroka.Remove(stroka.Length - 2, 1));
    return number;
}

int RandomNum = new Random().Next(100, 1000);
int result = DelTwoNum(RandomNum);
Console.WriteLine(RandomNum + " -> " + result);