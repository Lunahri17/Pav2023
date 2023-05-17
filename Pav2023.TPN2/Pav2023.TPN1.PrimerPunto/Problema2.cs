using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pav2023.TPN1
{
    internal class Problema2
    {
       public static double? Reversar(string numero)
        {
            numero = numero?.Replace(".", ",");

            if (!double.TryParse(numero, out var valor)) return null;

            string[] numeroLista = numero.Split(",");

            char[] enteros = numeroLista[0].ToCharArray();
            char[] enteros2 = numeroLista[1].ToCharArray();
            Array.Reverse(enteros);
            Array.Reverse(enteros2);

            string numeroReversed = ($"{new string(enteros)},{new string(enteros2)}");

            double.TryParse(numeroReversed, out double num);
            
            return num;
        }
    }
}
