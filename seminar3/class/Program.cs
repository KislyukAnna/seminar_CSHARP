Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

//int[] numbers = { 5, 123, 12312312 };
int[] numbers = new int[size];

Console.WriteLine($"Введите {size} элементов массива:");
for (int i = 0; i < size; i++)
{
    int input = int.Parse(Console.ReadLine()!);
    numbers[i] = input;
}


Console.WriteLine("Массив:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}