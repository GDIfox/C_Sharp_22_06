// Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [12345] -> [54321]

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

void RevMas(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1] ) = (arr[size - i - 1], arr[i]); // кортеж
    //   arr[0], arr[5 - 0 - 1] = arr[5 - 0 - 1], arr[0]
    //   arr[0], arr[4] = arr[4], arr[0]
    //   arr[1], arr[3] = arr[3], arr[1]  

}

int num = int.Parse(Console.ReadLine()!);    // В Massiv (size, from, to) - параметры должны отличаться!!! 
int start = int.Parse(Console.ReadLine()!);  // - от переменных = Это очень важно!!!!
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Massiv(num, start, stop);
Print(mass);
RevMas(mass);
Print(mass);
