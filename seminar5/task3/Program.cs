// Задайте двумерный массив из целых чисел. Сформируйте новый 
// одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива. 

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

double[] MeansRows(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            means[i] += matrix[i, j];
        }
        means[i] /= matrix.GetLength(1);
    }

    return means;
}

int[,] matrix = GetArray(3, 2);
PrintArray(matrix);

double[] means = MeansRows(matrix);
foreach (double item in means)
{
    Console.WriteLine(item);
}