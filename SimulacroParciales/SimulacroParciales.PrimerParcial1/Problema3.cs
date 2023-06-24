using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class Problema3
    {
        /*
         * Problema N° 3
         * Puntuación: 1
         * Cantidad de Pruebas: 5 (cada una 0.20)
         * Crear un método estático "CalcularYMostrar" que reciba 3 cadenas y 1 decimal, y retorna una cadena 
         * El primer parámetro, aunque es una cadena, representa a un número
         * El segundo parámetro, aunque es una cadnea, representa a un número
         * El tercer parámetro representa a un operador (solo se permiten +, -, * y /)
         * El método debe evaluar el tipo de operación y calcular la operación correspondiente.
         * El resultado, en decimal, de la operación se debe retornar en el parámetro del mismo tipo.
         * El método retorna una cadena con la representación de la operación, por ejemplo: "10+20=30" (sin espacios)
         * Se deben contemplar situaciones que puedan generar errores en las operaciones o situaciones con operadores no 
         * soportados
         * En cualquiera de las situaciones anómalas el método debe retornar el texto "Operacion no valida" (sin acentos)
         * Tiempo estimado: 15m
         */

        public static string CalcularYMostrar(string numero1, string numero2, string operador, out decimal resultado)
        {
            if (!decimal.TryParse(numero1, out decimal valor1) || !decimal.TryParse(numero2, out decimal valor2))
            {
                resultado = 0;
                return "Operacion no valida";
            }

            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    break;

                case "*":
                    resultado = valor1 * valor2;
                    break;

                case "/":
                    try
                    {
                        resultado = valor1 / valor2;
                    } catch (Exception ex)
                    {
                        resultado = 0;
                        return "Operación no valida";
                    }
                    break;

                default:
                    resultado = 0;
                    return "Operación no valida";
            }

            return $"{numero1}{operador}{numero2}={resultado}";
        }
    }
}
