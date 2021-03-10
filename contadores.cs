using System;

namespace piramide
{    
    internal class Program {

        public static void Main(string[] args){
            
            int numero = 0;
            
            Console.WriteLine("Ingrese el numero: ");
	        numero = Int32.Parse(Console.ReadLine());

            AddNumbers(numero);
        }
        public static int AddNumbers(int numero)
        {
            int i = 0, j = 0;
            for( i=1; i<=numero; i++){
                for(j=numero; j>i; j--){
                    Console.Write($"{j}");
                }
                    Console.WriteLine($"");
            }
            return numero;
        }
    }
}