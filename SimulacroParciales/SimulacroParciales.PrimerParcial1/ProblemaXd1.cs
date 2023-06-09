using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemaXd1
    {
        /*
         Problema:
            Dada una lista de números enteros, implementa una función que encuentre el par de números cuya suma sea igual 
            a un objetivo dado. La función debe devolver una lista con los dos números encontrados, o una lista vacía 
            si no se encuentra ningún par que cumpla la condición.

            Ejemplo de entrada:
            Lista: [2, 4, 7, 11, 15]
            Objetivo: 9

            Resultado esperado:
            [2, 7]

            Restricciones:

            Debes implementar una función llamada "EncontrarParSumaObjetivo" que tome una lista de enteros y un objetivo 
            como argumentos y devuelva una lista con los dos números que suman el objetivo.

            Si no se encuentra ningún par que cumpla la condición, la función debe devolver una lista vacía ([]).
            Puedes asumir que siempre habrá una única solución.
            Tiempo estimado: 20 minutos
        */

        public static List<int> EncontrarParSumaObjetivo(List<int> listaEnteros, int sumaObjetivo)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < listaEnteros.Count(); i++)
            {
                for (int i2 = i+1; i2 < listaEnteros.Count(); i2++)
                {
                    if (listaEnteros.ElementAt(i) + listaEnteros.ElementAt(i2) == sumaObjetivo)
                    {
                        result.Add(listaEnteros.ElementAt(i));
                        result.Add(listaEnteros.ElementAt(i2));
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
