using System;

class Program
{
    double CalculateAverage(int[] values)
    {
        double average;
        if (values.Length > 1)
        {
            for (int i = 0; i < values.Length; i ++)
            {
                average += values[i];
            }
            average = average / values.Length;
        } else
        {
            Console.WriteLine("not enough values");
        }
        return average;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Zmiana 1");
        Console.WriteLine("Zmiana 2");
        Console.WriteLine("Zmiana 3");
        Console.WriteLine("Zmiana 4");
        
    }
}