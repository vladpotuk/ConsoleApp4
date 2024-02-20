using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть початок діапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Числа Фібоначчі в діапазоні від {start} до {end}:");

        
        PrintFibonacciNumbersInRange(start, end);
    }

    
    static void PrintFibonacciNumbersInRange(int start, int end)
    {
        int a = 0;
        int b = 1;
        int c = a + b;

        while (c <= end)
        {
            if (c >= start)
            {
                Console.Write($"{c} ");
            }
            a = b;
            b = c;
            c = a + b;
        }

        Console.WriteLine(); 
    }
}
