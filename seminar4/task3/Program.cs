// Задание 3. Совместная работа
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] GetArraySizeFromConsole()
{
    Console.Write("Size (не более 8) : ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

int GetNumberFromArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = array[i] * (int)Math.Pow(10, array.Length - i -1);
        result += temp;
    }
    return result;
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

int[] array = GetArraySizeFromConsole();
PrintArray(array);
System.Console.WriteLine(GetNumberFromArray(array));
