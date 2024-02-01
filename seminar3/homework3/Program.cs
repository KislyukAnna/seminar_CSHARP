//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
        double min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]<min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        //Напишите свое решение здесь
        double max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;     
      
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
        double min = FindMin(array);
        double max = FindMax(array);
        double dif = max - min;
        Console.WriteLine(dif);
    }
}