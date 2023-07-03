// == Работа с текстом
// дан текст, необходимо пробелы изменить на черточки
// маленькие буквы "к" заменить на заглавные "К",
// а заглавные "С" заменить на маленькие "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю? ";

// важно: 
//string s = "qwerty"
//            012345
// например s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty; // инициализация пустой строки
    int length = text.Length; //определяем длинну строки
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, "к", "К");
Console.WriteLine();