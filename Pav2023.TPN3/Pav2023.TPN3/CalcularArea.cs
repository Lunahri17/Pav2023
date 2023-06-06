using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2023.TPN3
{
    internal static class CalcularArea
    {
        public static void CalculoArea()
        {
            double numero1, numero2;
            Console.WriteLine("Ingrese el nombre de la figura: ");
            
            switch (Console.ReadLine().ToLower())
            {
                case "rectangulo":
                    Console.WriteLine("lado 1: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("lado 2: ");
                    numero2 = double.Parse(Console.ReadLine());
                    Rectangulo r = new Rectangulo();
                    Console.WriteLine(($"Area del Rectangulo: {r.Area(numero1,numero2)}"));
                    break;

                case "circulo":
                    Console.WriteLine("Radio: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Circulo c = new Circulo();
                    Console.WriteLine(($"Area del Circulo: {c.Area(numero1)}"));
                    break;

                case "triangulo":
                    Console.WriteLine("Base: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    numero2 = double.Parse(Console.ReadLine());
                    Triangulo t = new Triangulo();
                    Console.WriteLine(($"Area del Triangulo: {t.Area(numero1, numero2)}"));
                    break;

                default:
                    Console.WriteLine("Ingresó mal el nomrbe de la figura");
                    break;
            }
        }
    }
}
