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
        if (!values.Length > 0)
        {
            return -1;
        }
        int ret = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (ret < values[i])
            {
                ret = values[i];
            }
        }
        return ret;
    }

    int CalculateMin(int[] values)
    {
        if (!values.Length > 0)
        {
            return -1;
        }
        int ret = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (ret > values[i])
            {
                ret = values[i];
            }
        }
        Console.WriteLine(ret);
        Console.WriteLine($"Minimum to : {ret}" + " cyfra");
        

        return ret;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Zmiana 1");
        Console.WriteLine("Zmiana 2");
        Console.WriteLine("Zmiana 3");
        Console.WriteLine("Zmiana 4");
        Console.WriteLine("Zmiana 5");

        
    }
}