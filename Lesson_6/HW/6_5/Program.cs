// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] RandomNums(int num)
{
    int[] array = new int[num];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(-100, 100);

    return array;
}

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void PlusNums(int[] arr)
{
    int length = arr.Length;
    int count = 0;

    for (int i = 0; i < length; i++)
        if (arr[i] > 0)
            count++;
    Console.WriteLine($"Положительных чисел = {count}");
}

Console.Write("Введите длинну масиива: ");
int dlmas = int.Parse(Console.ReadLine()!);
int[] mas = RandomNums(dlmas);
Print(mas);
Console.WriteLine();
PlusNums(mas);
