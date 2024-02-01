//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        //Введите сюда свое решение

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange & numbers[i] <= maxRange)
            {
                count += 1;
            }
        }
        return count;

    }

    public static void PrintResult(int[] array)
    {

        //Введите сюда свое решение

        int resultCount = CountItemsRange(array, 10, 90);
        Console.WriteLine(resultCount);

    }

}

