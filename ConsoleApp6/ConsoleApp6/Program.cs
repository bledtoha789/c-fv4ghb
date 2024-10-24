//2
using System;
public class UniqueElementsCounter
{
    public static int CountUniqueElements(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        int count = 1;

        for (int i = 1; i < numbers.Length; i++)
        {

            bool isUnique = true; for (int j = 0; j < i; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                count++;
            }
        }
        return count;
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 69, 3, 52, 4, 27, 1488, 5, 42, 4 };
        int uniqueCount = CountUniqueElements(numbers);
        Console.WriteLine($"Количество уникальных элементов: {uniqueCount}");
    }
}