// Задача 4*(не обязательная): Задайте строку, состоящую 
// из слов, разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. В 
// полученной строке слова должны быть также разделены 
// пробелами
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

//функция для формирования строки с обратным порядком слов исходной строки
string FormStringInReverseOrder(string input)
{
    string[] words = input.Split(new char[] { ' ' });

    string temp;

    for (int i = 0; i < words.Length / 2; i++)
    {
        temp = words[i];
        words[i] = words[words.Length - 1 - i];
        words[words.Length - 1 - i] = temp;
    }

    string revers_text = string.Join(" ", words);

    return revers_text;
}

System.Console.Write("Введи текст: ");
//string input = "И поэтому все так произошло";
string input = Console.ReadLine()!;
string revers_text = FormStringInReverseOrder(input);
Console.WriteLine($"{revers_text}");
