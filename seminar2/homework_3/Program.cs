// Задача 3: Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.Write("Введите число из отрезка [10, 99]:");
int num = int.Parse(Console.ReadLine());

if (num >= 10 & num <=99)
{
    int first_num=num/10;
    int second_num=num%10;

    if (first_num>=second_num)
    {
        System.Console.WriteLine(first_num);
    }
    else
    {
        System.Console.WriteLine(second_num);
    }
}
else
{
    System.Console.WriteLine("ты точно хотел это ввести?");
}