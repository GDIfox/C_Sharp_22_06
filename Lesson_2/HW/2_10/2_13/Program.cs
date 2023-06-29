// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите пожалуйста цифру дня недели: ");
int DenNedeli = Convert.ToInt32(Console.ReadLine()!);

switch (DenNedeli){
    case 1:
    Console.WriteLine("Понедельник - рабочий день");
    break;
    case 2:
    Console.WriteLine("Вторник - рабочий день");
    break;
    case 3:
    Console.WriteLine("Среда - рабочий день");
    break;
    case 4:
    Console.WriteLine("Четверг - рабочий день");
    break;
    case 5:
    Console.WriteLine("Пятница - рабочий день");
    break;
    case 6:
    Console.WriteLine("Суббота - выходной день");
    break;
    case 7:
    Console.WriteLine("Воскресенье - выходной день");
    break;
    default:
    Console.WriteLine("Неизвестный день недели - введите корректное число от 1 до 7");
    break;
}

