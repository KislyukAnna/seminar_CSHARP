// принимает на вход трехзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре

int a = 487;

//double result = Math.Pow((a % 100) / 10, (a % 10));
int second = (a % 100) / 10;
int therd = a % 10;
int result = 1;

for (int i = 1; i <= therd; i++)
{
    result = result*second;
}

System.Console.WriteLine(result);