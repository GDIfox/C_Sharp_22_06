// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double RaznicaMaxAndMin(double[] arr)
{   
    double max = arr[0];
    double min = arr[0];
    double razn = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max )
            max = arr[i];
            
        if (arr[i] < min)
            min = arr[i];
            
        razn = max - min;
    }   
    return razn;
}

void Print(double[] arr)
{
    double size = arr.Length;  

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();    
}

double[] Massiv(int size, int from, int end)
{
    double[] arr = new double[size]; //формирование нового массива размером size

    for (int i = 0; i < size; i++)
        arr[i] = Convert.ToDouble(new Random().Next(from, end + 1)/10.0); // + 1 = это сдвиг справа, т.к. указав "край" чтобы он же в массив и попал
    return arr;
}

int num = int.Parse(Console.ReadLine()!);    // В Massiv (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);

double[] mass = Massiv(num, start, stop);
Print(mass);

System.Console.WriteLine(RaznicaMaxAndMin(mass));