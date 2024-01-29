// Console.WriteLine("Введите строку для преобразования в число:");

// int result;

// bool isParse = int.TryParse(Console.ReadLine()!, out result);

// if (isParse)
// {
//     Console.WriteLine($"Успешно. {result}");
// }
// else
// {
//     Console.WriteLine("Попробуйте заного...");
// }

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

int num = 8569;
int first_num = num / 100;
if (num / 100 != 0)
{
    System.Console.WriteLine(first_num % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}