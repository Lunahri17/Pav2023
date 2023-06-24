using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaParcialProfe1
    {
        /*
        * Crear un método público "Sumados" que reciba un array de enteros y un número entero 
        * y retorne un array de enteros.
        * El parámetro array contiene un conjunto de números (que deberían ser distintos entre si).
        * El parámetro entero representa un número que se debería formar con la suma de dos números 
        * del array.
        * El array de retorno deberá contener los índices de los dos números que sumados dan 
        * el parámetro.
        *
        * Si los números en el array recibido no son distintos debe retornar un array vacío.
        * En cualquier otro caso alternativo, también se debe retornar un array vacío.
        * 
        * Aclaraciones:
        *   - Solo hay una combinación correcta
        *   - No importa el orden del array de retorno
        *   - El mismo numero no se usará dos veces e.g no habrá una respuesta [1, 1]
        */

        public static int[] Sumados(int[] numeros, int numeroSumados)
        {

            int[] numerosOrdenados = numeros;
            
            Array.Sort(numerosOrdenados);

            for (int i = 1; i < numerosOrdenados.Length; i++)
            {
                if (numerosOrdenados[i] == numerosOrdenados[i - 1])
                {
                    return new int[] {};
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                {
                    if ((numeros[i] + numeros[j]) == numeroSumados)
                    {
                        return new int[] {i,j};
                    }
                }
            }

            return new int[] { };
        }

    }
}
