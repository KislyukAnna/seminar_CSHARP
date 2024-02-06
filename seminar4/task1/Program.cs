// Задание 1. Совместная работа
// Семинар 4. Функции
// 20 мин
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

int[] GetRandomArray(int size, int minValue = 1, int maxValue = 99)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);

    }
    return array;
}

int[] GetArrayFromConsole()
{
    Console.Write("Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Console.WriteLine($"Enter {size} elements:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;

}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (IsPrime(elem))
        {
            count++;
        }
    }
    return count;
}


int[] array = GetRandomArray(6);
PrintArray(array);

int[] array2 = GetArrayFromConsole();
PrintArray(array2);

System.Console.WriteLine($"результат: {CountPrimeNumbers(array)}");
System.Console.WriteLine($"результат: {CountPrimeNumbers(array2)}");