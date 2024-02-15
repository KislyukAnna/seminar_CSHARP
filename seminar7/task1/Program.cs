// int Factorial(int n)

// {
//     if (n < 0)
//     {
//         return -1;
//     }
//     if (n == 0)
//     {
//         return 1;
//     }
//     return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(-5));

// Задание 1. Совместная работа
// Семинар 7. Рекурсия
// 15 мин
// Обсудить компоненты рекурсии
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumDigit(int value)
{
    value = Math.Abs(value);
    if (value == 0)
    {
        return 0;
    }
    int sum = value % 10 + SumDigit(value / 10);
    return sum;
}
Console.WriteLine($"введите число");
int n = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine(SumDigit(n));