int a = -3;
int b = 9;

if (a == b * b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}


int N = -3;
if (N < 0)
{
    N = -N;
}
int i = -N;
while (i <= N)
{
    System.Console.Write(i);
    System.Console.Write(' ');
    i += 1;
}
