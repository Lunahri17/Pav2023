using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2023.TPN1
{
    internal class Problema4
    {
        public static double Truncar(string numero, int cantidadDecimales)
        {
            cantidadDecimales = 0;

            numero = numero?.Replace(".", ",");

            if (!double.TryParse(numero, out var valor)) return 0;
            
            cantidadDecimales = valor.ToString().Contains(",") ? 
                valor.ToString().Split(",")[1].Length : 0;
            
            return Math.Truncate(valor * 100) / 100;
        }
    }
}
