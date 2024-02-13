// Считать строку с консоли, состоящую из латинских 
// букв в нижнем регистре. Выяснить, сколько среди 
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

bool IsVowels(char liter)
{
    return  liter == 'a' || liter == 'o' || liter == 'u' ||
            liter == 'e' || liter == 'i' || liter == 'y';
}

int CountVowels(string str)
{
    int count = 0;
    foreach (char elem in str)
    {
        if (IsVowels(elem))
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введи слово: ");
string str = Console.ReadLine()!;
System.Console.WriteLine($"гласных букв в тексте: {CountVowels(str)}");
