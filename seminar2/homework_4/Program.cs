// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

System.Console.Write("Введите натуральное число:");
int N = int.Parse(Console.ReadLine());

string str_N = N.ToString();

System.Console.WriteLine(str_N);

for (int i = 0; i < str_N.Length; i++)
{
    System.Console.Write($"{str_N[i]}");

    if (i != str_N.Length - 1)
    {
        System.Console.Write(",");
    }
}