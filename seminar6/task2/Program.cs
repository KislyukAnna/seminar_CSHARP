// Задание 2. Работа в сессионных залах

// На основе символов строки (тип string) сформировать массив 
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] GetCharArreyFromString(string str)
{
    int size = str.Length;
    char[] char_array = new char[size] ;
    int i = 0;

    foreach (char elem in str)
    {
        char_array[i] = elem;
        i++;
    }
    return char_array;
}
// вывод массива
void PrintArray(char[] array)
{
    Console.Write("[");
    foreach (char elem in array)
    {
        Console.Write("'"+elem + "'" + " ");
    }
    Console.WriteLine("]");
}

string str = "Hello!";
char[] char_array = GetCharArreyFromString(str);
//PrintArray(char_array);
//System.Console.WriteLine(char_array);
 Console.WriteLine("['"+string.Join("', '",char_array)+"']");

 System.Console.WriteLine("H".);