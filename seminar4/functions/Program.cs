// создание рандомного массива
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);

    }
    return array;
}

// создание массива с ручным вводом элементов
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

// создание рандомного массива с ручным вводом размера массива
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

//Определение введено ли число с консоли
bool IsNum(int input) 
{
    int output;
    bool result = int.TryParse(input, out output);
    return result;
} 

// функция подсчета элементов массива, отвечающих каким то требваниям
int CountPrimeNumbers(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (функция определения элементов, отвечающих каким то требваниям(elem))
        {
            count++;
        }
    }
    return count;
}

// Формирование целого числа из цифр из массива.
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

//функция определения простых чисел в массиве от 1 до числа number
bool IsPrime(int number) 
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

//функция определения четности числа
bool IsEven(int number) 
{
    if (number % 2 == 0)
    {
        return true;
    } 
}

//Сумма цифр числа 
int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;

        sum += digit;

        number /= 10;
    }
    return sum;
}
