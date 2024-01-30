// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

System.Console.Write("Введите координату Х:");
int x = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату Y:");
int y = int.Parse(Console.ReadLine());

//System.Console.WriteLine($"({x},{y})");

if (x == 0 | y == 0)
{
    System.Console.WriteLine("точка лежит на оси координат");
}
else if (x > 0 & y > 0)
{
    System.Console.WriteLine("1");
}
else if (x < 0 & y > 0)
{
    System.Console.WriteLine("2");
}
else if (x < 0 & y < 0)
{
    System.Console.WriteLine("3");
}
else 
{
    System.Console.WriteLine("4");
}