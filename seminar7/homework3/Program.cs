// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

// создание рандомного массива с ручным вводом размера массива
int[] GetArraySizeFromConsole(int size)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}
// функция печати элементов массива в обратном порядке
void PrintReverseArrayElements(int[] array, int size)
{
    if (size >= 1)
    {
        Console.Write($"{array[size-1]} ");
        PrintReverseArrayElements(array, size-1);
    }
    return;
}


Console.Clear();
Console.Write("Введи размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArraySizeFromConsole(size);
Console.WriteLine("[" + string.Join(", ", array) + "]");
PrintReverseArrayElements(array, size);