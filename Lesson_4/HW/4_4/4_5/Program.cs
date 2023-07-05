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
            summa += nums % 10;
            nums /= 10;
        }
        Console.WriteLine("Сумма цифр числа= " + summa);
    }

SummaNums(args);





// void SummaNum()
// {
//     int[] nums = new int[10];
//     Random rand = new Random();
//     for (int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = rand.Next(0, 50);
//         Console.Write(nums[i] + " ");
//     }

// }
// SummaNum();

// Random random= new Random();
// // Console.WriteLine("случайное число -> " + random.Next(0, 100));
// // Console.WriteLine("");

// string stroka = Convert.ToString(random.Next(0, 1000));
// Console.WriteLine("случайное число -> " + stroka);
// char[] array = new char[stroka.Length];

// for (int i = 0; i < stroka.Length; i++)
// {
//     array[i] = stroka[i];
//     Console.WriteLine("=>" + array[i]);
//     int numbers = (int)Char.GetNumericValue(array[i]);
//     int sum = array.Sum();
//     Console.Write("" + sum);
// }