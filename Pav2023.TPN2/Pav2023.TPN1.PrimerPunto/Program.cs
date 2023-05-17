using System;

namespace Pav2023.TPN1.PrimerPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ingrese el primer numero: ");
            //double nuemro1 = double.Parse(Console.ReadLine());

            //Console.Write("Ingrese el segundo numero: ");
            //double nuemro2 = double.Parse(Console.ReadLine());

            //Console.Write("Ingrese el operador: ");
            //String operador = Console.ReadLine();

            //Console.WriteLine($"{nuemro1} {operador} {nuemro2} = {new Problema1().Calcular(nuemro1,nuemro2,operador)}");
            //int nume = 0;
            //Problema4.Truncar("10,0123", nume);

            //Problema2.Reversar("12345.123");

            int[] lista = {7,13};
            int numero = Problema3.EncontrarPrimo(lista);
        }
    }
}
