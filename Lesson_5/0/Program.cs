// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SummaNums(string[] args)
    {
        Console.Write("ввиедите натуральное число = ");
        var nums = Convert.ToInt32(Console.ReadLine()!);
        var summa = 0;
        while(nums > 0)
        {
            summa = summa + (nums % 10);
            Console.WriteLine("summa= " + summa);
            nums = nums / 10;
            Console.WriteLine("nums= " + nums);
        }
        Console.WriteLine("Сумма цифр числа= " + summa);
    }

SummaNums(args);
//---------------------------------------------------------------------//

// реализация примера через строки (если будут "буквы" - то сломается)
double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]); // "если этот символ "цифра" то превращаю этот символ в цифру"
        sum += m;
    }
    return sum;
}

int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitSum(n));

//-------------------------------------------------------------------------------//

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

//-----------  другой вариант.....

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

int[] mass = EightMass(num, start, stop);
Print(mass);

//----------------------------------------------------------------------------------//

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double PowNum(int a, int b)
{
    double n_pow = 1; // всегда с 1-цы - если произведение или частное в выражении
    int b_abs = Math.Abs(b); // как вариант исключения отрицательного числа

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a;
        else
            n_pow /= a;
    }
    return n_pow;
}

Console.WriteLine("Введеите число= ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень исла= ");
int num_2 = int.Parse(Console.ReadLine()!)

Console.WriteLine(PowNum(num_1, num_2));

//-------------------------------------------------------------------------------------//

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// пример реализации с циклом for

int SumNums (int num)
{
    int n_sum = 0;

    for (; num != 0; num /= 10)
        n_sum += num % 10; 

    return n_sum;
}

int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums(num_2));
