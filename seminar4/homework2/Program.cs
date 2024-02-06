// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// создание рандомного массива с ручным вводом размера массива
int[] GetArraySizeFromConsole()
{
    Console.Write("Введи размер массива : ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

// функция подсчета элементов массива, отвечающих требваниям четности
int CountEvenElements(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (elem % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


Console.Clear();
int[] array = GetArraySizeFromConsole();
PrintArray(array);
int count = CountEvenElements(array);
System.Console.WriteLine($"Четных элементов в массиве: {count} штук");
