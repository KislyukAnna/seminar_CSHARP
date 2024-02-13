// Задача 1. Задайте массив символов (тип char[])ю Создайте строку из символов этого массива.

// функция склеивания символов в строку
string PrintStringFromChars(char[] chars)
{
    string sim = "";
    foreach (char e in chars)
    {
        sim += e;
    }
    return sim;
}

char[] chars = new char[] {'a','b','c','d'};
string str = PrintStringFromChars(chars);
System.Console.WriteLine(str);




