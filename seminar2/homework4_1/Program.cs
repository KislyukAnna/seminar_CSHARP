// Задача 4: Вывод цифр числа через запятую

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    string str_N = (N % 10).ToString();

    N /= 10;

    while (N > 0)
    {
        int number = N % 10;

        str_N = number.ToString() + "," + str_N;

        N /= 10;
    }
    System.Console.WriteLine(str_N);
}