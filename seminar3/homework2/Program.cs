//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь        
      int count = 0;

       for (int i = 0; i < numbers.Length; i++)
       {
            if (numbers[i] % 2 == 0)
            {
                count += 1;
            }
        }
        return count;

    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
        int resultCount = CountEvenItems(array);
        Console.WriteLine(resultCount);
 
    }
}