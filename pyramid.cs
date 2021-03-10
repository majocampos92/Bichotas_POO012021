using System;

namespace pyramid
{    
    internal class Program {

        public static void Main(string[] args){
            
            int number = 0;
            
            Console.WriteLine("Enter a number: ");
	        number = Int32.Parse(Console.ReadLine());

            AddNumbers(number);
        }
        public static int AddNumbers(int number)
        {
            int i = 0, j = 0;
            for( i=1; i<=number; i++){
                for(j=number; j>i; j--){
                    Console.Write($"{j}");
                }
                    Console.WriteLine($"");
            }
            return number;
        }
    }
}