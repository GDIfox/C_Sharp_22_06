// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Chetnost(int[] arr)
{   
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2) == 0)
            count = count + 1; 
    }
    return count;
}

void Print(int[] arr)
{
    int size = arr.Length;  

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();    
}

int[] Massiv(int size, int from, int to)
{
    int[] arr = new int[size]; //формирование нового массива размером size

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1); // + 1 = это сдвиг справа, т.к. указав "край" чтобы он же в массив и попал
    return arr;
}

int num = int.Parse(Console.ReadLine()!);    // В Massiv (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Massiv(num, start, stop);
Print(mass);

System.Console.WriteLine(Chetnost(mass));
