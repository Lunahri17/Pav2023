using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaXd3
    {
        /*
         * Problema:
            Dada una cadena de caracteres, implementa una función que encuentre el carácter que aparece con mayor 
        frecuencia en la cadena. Si hay múltiples caracteres con la misma frecuencia máxima, la función debe devolver 
        el primero de ellos.

            Ejemplo de entrada:
            Cadena: "abracadabra"

            Resultado esperado:
            'a'

            Explicación: En la cadena "abracadabra", el carácter 'a' aparece 5 veces, más frecuentemente que cualquier 
        otro carácter.

            Restricciones:

            Debes implementar una función llamada "CaracterMasFrecuente" que tome una cadena como argumento y devuelva 
        el carácter más frecuente.
            Puedes asumir que la cadena no estará vacía y contendrá solo caracteres alfabéticos en minúsculas.
            Si hay empate entre varios caracteres con la frecuencia máxima, la función debe devolver el primero de ellos.
            Tiempo estimado: 20 minutos
        */

        public static char CaracterMasFrecuente(string cadena = "aabb")
        {
            char letraMaximo = cadena.ElementAt(0);
            int cantidad = 0, cantidadLetraMaxima = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = i;j < cadena.Length; j++)
                {
                    if (cadena[j] == cadena[i])
                    {
                        cantidad++;
                    }
                }

                if (cantidad > cantidadLetraMaxima)
                {
                    letraMaximo = cadena[i];
                    cantidadLetraMaxima = cantidad;
                }

                cantidad = 0;
            }

            return letraMaximo;
        }
    }
}
