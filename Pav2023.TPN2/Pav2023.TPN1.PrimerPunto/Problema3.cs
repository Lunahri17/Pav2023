using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pav2023.TPN1
{
    internal class Problema3
    {
        public static int EncontrarPrimo(int[] listaNumeros)
        {
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i]<2) return i;
                if (Primo(listaNumeros[i])) return i;
            }

            return -1;
        }

        private static bool Primo(int numero)
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
     }
}
