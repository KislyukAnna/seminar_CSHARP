﻿// Задание 2. Работа в сессионных залах

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


void PrintRange(int n, int m = 1)
{
    if (m > n)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{m} ");
    PrintRange(n, m + 1);
}

PrintRange(12);