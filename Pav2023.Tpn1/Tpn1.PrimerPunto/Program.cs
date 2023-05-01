using System;
using System.Reflection.Metadata;
using Tpn1.PrimerPunto.Funciones;

namespace Tpn1.PrimerPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
                
                if(num <= 0) {
                    Console.Clear();
                    Console.WriteLine("Ingrese un número positivo\n");
                    
                }
            } while (num < 0);

            Console.WriteLine("\nEl factorial es: " + factorial(num));
            Figura x = new Figura();
            x.CalcularArea();

        }

        static decimal factorial(int n) {
        
            int fact = 1;
            
            for (int i = 1; i <= n; i++) {
                fact *= i;
            }
            
            return fact;
        }

        /*static float factorialRec(int n) {
            
            if (n == 0) {
                return 1;
            }

            return factorialRec(n - 1) * n;
        }*/
    }
}
