// Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

string CheckNum(int[] arr, int ch)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == ch)  return "Yes";
        
    }
    return "No";  
}

void Print(int[] arr)
{
    int size = arr.Length;  

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();    
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size]; //формирование нового массива размером size

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1); // + 1 = это сдвиг справа, т.к. указав "край" чтобы он же в массив и попал
    return arr;
}

int num = int.Parse(Console.ReadLine()!);    // В EightMass (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);
System.Console.WriteLine(CheckNum(mass, d));


