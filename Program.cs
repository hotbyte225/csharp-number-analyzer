using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Number Analyzer");
        Console.WriteLine("----------------");

        int count = ReadNumberCount();
        List<int> numbers = ReadNumbers(count);

        ShowAnalysis(numbers);
    }

    static int ReadNumberCount()
    {
        Console.Write("How many numbers do you want to enter? ");
        int count;

        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }

        return count;
    }

    static List<int> ReadNumbers(int count)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Try again: ");
            }

            numbers.Add(value);
        }

        return numbers;
    }

    static void ShowAnalysis(List<int> numbers)
    {
        int even = 0;
        int odd = 0;
        int positive = 0;
        int negative = 0;
        int zero = 0;

        foreach (int n in numbers)
        {
            if (n % 2 == 0) even++;
            else odd++;

            if (n > 0) positive++;
            else if (n < 0) negative++;
            else zero++;
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Even numbers: {even}");
        Console.WriteLine($"Odd numbers: {odd}");
        Console.WriteLine($"Positive numbers: {positive}");
        Console.WriteLine($"Negative numbers: {negative}");
        Console.WriteLine($"Zero values: {zero}");

        Console.WriteLine($"Max value: {GetMax(numbers)}");
        Console.WriteLine($"Min value: {GetMin(numbers)}");
        Console.WriteLine($"Average value: {GetAverage(numbers):0.00}");
    }

    static int GetMax(List<int> numbers)
    {
        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
                max = n;
        }

        return max;
    }

    static int GetMin(List<int> numbers)
    {
        int min = numbers[0];

        foreach (int n in numbers)
        {
            if (n < min)
                min = n;
        }

        return min;
    }

    static double GetAverage(List<int> numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return (double)sum / numbers.Count;
    }
}
