using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaXd4
    {
        /*
     
            Problema N° 4
            Puntuación: 1.5
            Cantidad de Pruebas: 5 (cada una 0.30)
            Crear un método estático "Reemplazar" que reciba una cadena y un número variable de objetos.
            La cadena recibida funciona como una máscara, donde el caracter # debe reemplazarse por los objetos enviados.
            El método debe retornar la cadena con los valores reemplazados.

            Si no hay coincidencia entre los caracteres a reemplazar y los objetos recibidos se debe retornar null.

            Tiempo estimado: 15m


                ca de n a
        */

        public static string Reemplazar(string mascara, params Object[] objetos)
        {
            int contadorHashtag = 0;
            foreach (char c in mascara)
            {
                if (c.Equals('#'))
                {
                    contadorHashtag++;
                }
            }

            if (objetos.Length != contadorHashtag)
            {
                return null;
            }

            string[] mascara2 = mascara.Split("#");

            for (int i = 0 ; i < mascara2.Length - 1 ; i++)
            {
                mascara2[i] += objetos[i].ToString();
            }

            return mascara2.ToString();
        }
    }

    
}
