// Задайте массив из N случайных целых чисел (N вводится с 
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и 
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]  => 2

int[] GetArraySizeFromConsole()
{
    Console.Write("Введи размер массива : ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

// вывод массива
void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

// функция подсчета элементов массива, отвечающих требваниям 
// оканчиваются на 1 и делятся нацело на 7
int CountNecessaryElement(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (elem % 10 == 1 && elem % 7 == 0) 
        {
            count++;
        }
    }
    return count;
}


Console.Clear();
int[] array = GetArraySizeFromConsole();
PrintArray(array);
int count = CountNecessaryElement(array);
System.Console.WriteLine($"Элементов в массиве, которые оканчиваются на 1 и делятся нацело на 7 : {count} шт.");