using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2023.TPN4
{
    internal static class CalcularArea
    {
        public static void CalculoArea()
        {
            double numero1, numero2;
            Console.Write("Ingrese el nombre de la figura: ");

            switch (Console.ReadLine().ToLower())
            {
                case "rectangulo":
                    Console.Write("\nlado 1: ");
                    if (!double.TryParse(Console.ReadLine(),out numero1))
                    {
                        Console.WriteLine("No ingresó un digito");
                        break;
                    }

                    Console.Write("lado 2: ");
                    if (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("No ingresó un digito");
                        break;
                    }

                    Figura r = new Rectangulo();
                    Console.WriteLine(($"Area del Rectangulo: {r.Area(numero1, numero2)}"));
                    break;

                case "circulo":
                    Console.Write("\nRadio: ");
                    if (!double.TryParse(Console.ReadLine(), out numero1))
                    {
                        Console.WriteLine("No ingresó un digito");
                        break;
                    }

                    Figura c = new Circulo();
                    Console.WriteLine(($"Area del Circulo: {c.Area(numero1)}"));
                    break;

                case "triangulo":
                    Console.Write("\nBase: ");
                    if (!double.TryParse(Console.ReadLine(), out numero1))
                    {
                        Console.WriteLine("No ingresó un digito");
                        break;
                    }

                    Console.Write("Altura: ");
                    if (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("No ingresó un digito");
                        break;
                    }

                    Figura t = new Triangulo();
                    Console.WriteLine(($"Area del Triangulo: {t.Area(numero1, numero2)}"));
                    break;

                default:
                    Console.WriteLine("Ingresó mal el nomrbe de la figura");
                    break;
            }
        }
    }
}
