// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Massiv()
{
    int[] massiv = new int[10]; // длинна массива
    Random rand = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rand.Next(0, 50); // диапазон случайных чисел
        Console.Write(massiv[i] + " ");
    }

}
Massiv();
