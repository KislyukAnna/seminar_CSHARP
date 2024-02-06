//является ли числом
bool IsNum(string input)
{
    int output;
    bool result = int.TryParse(input, out output);
    return result;
}


//Сумма цифр числа 
int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;

        sum += digit;

        number /= 10;
    }
    return sum;
}

//функция определения нечетности числа
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

while (true)
{
    System.Console.Write("Введите целое число или q для выхода: ");
    string input = Console.ReadLine()!;

    if (input == "q")
    {
        System.Console.WriteLine("Exit");
        break;
    }
    else
    {
        if (IsNum(input))
        {
            int number = int.Parse(input);
            if (IsEven(SumOfDigits(number)))
            {
                System.Console.WriteLine("Сумма цифр числа четная. Exit");
                break;
            }

        }
        else
        {
            System.Console.WriteLine("Ошибка ввода. Попробуй еще раз.");
        }
    }

}


