using System;

namespace Example1
{    
    internal class Program 
    {
        public static void Main(string[] args)
        { 
            int a = 0, b = 0;
            
            Console.WriteLine("Enter a value for a:");
	        a= Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplying {a} * {b} equals {MultiplyNumbers(a, b)}");
        }
        public static int MultiplyNumbers(int a, int b)
        {
            return a*b;
        }
    }
}