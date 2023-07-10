// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//  0  1   2   3          (index)
// [-4, -6, 89, 6] -> 0



int SumNumNeChetInd(int[] arr)
{   
    int sum = 0;
        
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            sum += arr[i];                                   
    }    
    return sum;
}

void Print(int[] arr)
{
    int size = arr.Length;  

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();    
}

int[] Massiv(int size, int from, int end)
{
    int[] arr = new int[size]; //формирование нового массива размером size

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, end + 1); // + 1 = это сдвиг справа, т.к. указав "край" чтобы он же в массив и попал
    return arr;
}

int num = int.Parse(Console.ReadLine()!);    // В Massiv (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Massiv(num, start, stop);
Print(mass);

System.Console.WriteLine(SumNumNeChetInd(mass));
