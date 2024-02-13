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
 // вывод массива строкой
 Console.WriteLine("["+string.Join(", ",array)+"]");
 Console.WriteLine("['"+string.Join("', '",char_array)+"']");


//функция "зеркало" массива
int[] ReverseArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
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
        if (elem) //(элемент,отвечающий каким то требваниям)
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

// Функция создания двумерного массива с рандомными значениями
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    // создадим массив рандомно
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }       
    return matrix;
}

// функция вывода двумерного массива
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");   //интерполяция строк
        }
        
        System.Console.WriteLine();
    }
}




// функция выделения из строки буквенных символов
string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
