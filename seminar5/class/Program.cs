// Функция создания двумерного массива с рандомными значениями
int[,] CreateMatrix(int rowCount, int columsCount, int minValue = 10, int maxValue = 10)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    // создадим массив рандомно
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
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


int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] table = new int[rows, cols];

    var rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Sum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }

    return sum;
}


int[,] array = GetArray(1, 2);
int[,] array2 = GetArray(2, 3, 9, 10);
int[,] array3 = GetArray(2, 3, maxValue: 9, minValue: 1);

PrintArray(array);
PrintArray(array2);
PrintArray(array3);

Console.WriteLine(Sum(array));
Console.WriteLine(Sum(array2));
Console.WriteLine(Sum(array3));