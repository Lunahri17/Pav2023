using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2023.TPN1
{
    internal class Problema1
    {
        public double Calcular(double numero1, double numero2, String operador)
        {
            switch (operador)
            {
                case "+":
                    return numero1 + numero2;
                    
                case "-":
                    return numero1 - numero2;

                case "*":
                    return numero1 * numero2;

                case "/":
                    return numero1 / numero2;
                default:
                    Console.WriteLine("Ingresó un Operador erroneo");
                    return 0;                        
            }
            
            
            
        }
    }
}
