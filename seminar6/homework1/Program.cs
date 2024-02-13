//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 

// Функция создания двумерного массива 
char[,] CreateCharArrey(int rowCount, int columsCount)
{
    char[,] array = new char[rowCount, columsCount];

    // создадим массив c консоли
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"введи элемент {i+1},{j+1} : ");
            array[i, j] = char.Parse(Console.ReadLine()!);
        }
    }       
    return array;
}

// функция вывода двумерного массива
void ShowCharArrey(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");   //интерполяция строк
        }
        Console.WriteLine();
    }
}

//функция создания строки из элементов массива
string CreateStringFromCharArrey(char[,] array)
{
    string str = "";
    foreach (char elem in array)
    {
        str += elem;
    }
    return str;
}

Console.Clear();
char[,] array = CreateCharArrey(2,3);
Console.Clear();
ShowCharArrey(array);
string str = CreateStringFromCharArrey(array);
System.Console.WriteLine('"'+ str + '"');