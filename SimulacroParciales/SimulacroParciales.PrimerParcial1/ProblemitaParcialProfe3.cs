using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaParcialProfe3
    {

        //------------------------------------------------------------------------------------------------
        //* Crear un método público "MayorImparNegativoNoPrimo" que reciba un array de enteros y
        //* retorne un entero.
        //* 
        //* El valor a retornar representa la posición (base 0) en el array del mayor número 
        //* impar menor a 0 que no sea un número primo, en caso de empate deberá retornar la posición del 
        //* primero en aparecer.
        //* En cualquier otro caso deberá retornar null;
        //* 
        //* Aclaración: Un número primo es un numero natural mayor que 1, por lo que deberá considerarse
        //* el valor absoluto para determinarlo.

        public static int? MayorImparNegativo(int[] enteros)
        {
            int numPrimoMayor = 0;
            int? numPrimoPosicion = null;

            for (int i = 0; i < enteros.Length; i++)
            {
                if (Math.Abs(enteros[i]) > 2)
                {
                    if (Primo(Math.Abs(enteros[i])) && enteros[i] < numPrimoMayor)
                    {
                        numPrimoMayor = enteros[i];
                        numPrimoPosicion = i;
                    }
                }
            }

            return numPrimoPosicion;
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
