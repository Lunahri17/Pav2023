using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class Problema1
    {
        /*
         * Problema N° 1
         * Puntuación: 1
         * Cantidad de Pruebas: 4 (cada una 0.25)
         * Crear un método estático "CalcularArea" que reciba 3 parametros y retorna un resultado (el área)
         * El primer número es obligatorio, el segúndo también es número pero opcional y nuleable, el tercero es del tipo Enum y también es opcional.
         * El tercer parámetro debe ser nuleable y si toma el valor null, el resultado del cálculo también es null.
         * El método debe calcular el área de las figuras representadas en la enumeración.
         * El método no debe generar excepciones y usar un tipo de dato punto flotante de 128 bits.
         * Ayuda: Enum es el tipo base que da origen a las enumeraciones
         * Tiempo estimado: 10m
         */

        public static decimal? CalcularArea(decimal numero1, decimal? numero2 = 0, Figura? formaFigura = null)
        {
            switch (formaFigura)
            {
                case Figura.Circulo: return (decimal)Math.PI * numero1 * numero1;

                case Figura.Triangulo: return (numero1 * numero2)/2;

                case Figura.Rectangulo: return numero1 * numero2;

                default: return null;
            }
            
        }

    }

    //La enumeración no se puede modificar
    public enum Figura
    {
        Circulo = 1,
        Triangulo,
        Rectangulo
    }
}
