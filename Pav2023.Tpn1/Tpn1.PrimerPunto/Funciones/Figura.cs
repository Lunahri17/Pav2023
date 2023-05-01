using System;
using System.Collections.Generic;
using System.Text;

namespace Tpn1.PrimerPunto.Funciones
{
    internal class Figura
    {
        private int ancho, alto;

        public void SetAncho(int n)
        {
            if (ancho >= 0)
            {
                ancho = n;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nDebe ingresar un numero positivo");
            }

        }

        public void SetAlto(int n)
        {
            if (alto >= 0)
            {
                alto = n;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nDebe ingresar un numero positivo");
            }
        }

        public void CalcularArea()
        {
            string respuesta;
            do
            {
                Console.WriteLine("\n\nCalculo de Area de un Rectangulo");

                Console.Write("\nIngrese el Alto: ");
                SetAlto(int.Parse(Console.ReadLine()));

                Console.Write("\nIngrese el Ancho: ");
                SetAncho(int.Parse(Console.ReadLine()));

                Console.WriteLine("\nEl area es: " + Area(ancho, alto));

                Console.Write("\nDesea ingresar otro número? ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta.Equals("si"));
        }

        static int Area(int ancho, int alto)
        {
            return ancho * alto;
        }
    }
}
