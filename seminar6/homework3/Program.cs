//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string FormatString(string str)
{
    string format_string = str.ToLower().Replace(" ", "");
    //Console.WriteLine(format_string);
    return format_string;
}

bool IsPalindrom(string input)
{
    string str = FormatString(input);

    bool palindrom = false;
    int size = str.Length;

    for (int i = 0; i < size / 2; i++)
    {
        if (str[i] == str[size - 1 - i])
        {
            palindrom = true;
        }
        else
        {
            palindrom = false;
            break;
        }
    }
    return palindrom;
}

void PrintAnswer(string input)
{
    if (IsPalindrom(input))
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
System.Console.Write("Введи текст: ");
string input = Console.ReadLine()!;
PrintAnswer(input);
