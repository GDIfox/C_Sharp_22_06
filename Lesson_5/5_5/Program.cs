// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 214

int[] NewArray(int[] arr)
{
    int Length = arr.Length;
    int[] arr_2;

    if (Length % 2 == 0) arr_2 = new int[Length / 2];
    else arr_2 = new int[Length /2 + 1];
    for(int i = 0; i < arr_2.Length; i++)
    {
        if(arr[i] != arr[Length - i - 1]) arr_2[i] = arr[i] * arr[Length - i - 1];
        else arr_2[arr_2.Length - 1] = arr[i];
    }

    return arr_2;
    
}

void PrintArray(int[] arr)
{
    var str = string.Join(" ", arr);
    Console.Write($"{str} ");
}
// void Print(int[] arr)
// {
//     int size = arr.Length;  

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();    
// }

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size]; //формирование нового массива размером size

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1); // + 1 = это сдвиг справа, т.к. указав "край" чтобы он же в массив и попал
    return arr;
}

int num = int.Parse(Console.ReadLine()!);    // В MassNums (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
PrintArray(mass);
System.Console.WriteLine();
int[] mass_2 = NewArray(mass);
PrintArray(mass_2);


