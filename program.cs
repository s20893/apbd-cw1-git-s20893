using System;

class Program
{
    double CalculateAverage(int[] values)
    {
        double average;
        for (int i = 0; i < values.Length; i ++)
        {
            average += values[i];
        }
        average = average / values.Length;
        return average;
    }

    int CalculateMax(int[] values)
    {
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Zmiana 1");
        Console.WriteLine("Zmiana 2");
        Console.WriteLine("Zmiana 3");
        Console.WriteLine("Zmiana 4");
        
    }
}