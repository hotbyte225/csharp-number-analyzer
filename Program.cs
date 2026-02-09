using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("N ni kiriting: ");
        int N = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < N; i++)
        {
            Console.Write($"{i + 1}-sonni kiriting: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int currentLength = 0;
        int currentSum = 0;

        int maxLength = 0;
        int maxSum = 0;

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                currentLength++;
                currentSum += num;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxSum = currentSum;
                }

                currentLength = 0;
                currentSum = 0;
            }
        }

  
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxSum = currentSum;
        }

        Console.WriteLine();
        Console.WriteLine($"Eng uzun segment uzunligi: {maxLength}");
        Console.WriteLine($"Yig‘indisi: {maxSum}");
    }
}