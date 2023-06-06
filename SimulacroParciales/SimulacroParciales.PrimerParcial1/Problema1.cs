using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    /*
         * Problema N° 5
         * Puntuación: 1
         * Cantidad de Pruebas: 4 (cada una 0.25)
         * Crear la clase Empleado con los siguientes atributos:
         * - Nombre (string)
         * - Legajo (int)
         * - Sueldo (double)
         * Crear los siguientes métodos estáticos:
         * - "Buscar": recibe un legajo y retorna el empleado que coincide con ese número
         * - "MejoresPagos": devuelve los empleados con el sueldo superior a la media
         * - "PeoresPagos": devuelve los empleados con el sueldo en la media o inferior a la media
         * En todos los casos, el método recibe cualquiera de los tipos enumerables que posee el framework.
         * Restricción: 
         * -La clase Empleado debe tener un constructor que reciba tres parámetros, uno por cada propiedad
         * Tiempo estimado: 15m
         */
    internal class Problema1
    {
        // Crear Clase Empleado
        // Agregar Atributos privados
        // Crear metodos
        // Crear Constructore
        public static string Buscar(List<Empleado> Empleados, int legajo)
        {
            foreach (Empleado emp in Empleados)
            {                
                if (emp.legajo == legajo)
                {
                    return emp.nombre;
                }
            }
            return "No se encontró el Emplreado";
        }

        public static List<Empleado> MejoresPagos(List<Empleado> Empleados)
        {
            if (Empleados.Count == 0)
            {
                return null;
            }

            double total = 0, media;
            List<Empleado> empleadoMayorMedia = new List<Empleado>();
            //Obtener la media de los empleados
            foreach (Empleado emp in Empleados)
            {
                total += emp.sueldo;
            }
            
            media = total / Empleados.Count;

            //Obtener los empleados mayores a la media

            foreach (Empleado emp in Empleados)
            {
                if(emp.sueldo > media)
                {
                    empleadoMayorMedia.Add(emp);
                }
            }
            return empleadoMayorMedia;
        }

        public static List<Empleado> PeoresPagos(List<Empleado> Empleados)
        {
            if (Empleados.Count == 0)
            {
                return null;
            }

            double total = 0, media;
            List<Empleado> empleadoMenorMedia = new List<Empleado>();
            //Obtener la media de los empleados
            foreach (Empleado emp in Empleados)
            {
                total += emp.sueldo;
            }

            media = total / Empleados.Count;

            //Obtener los empleados mayores a la media

            foreach (Empleado emp in Empleados)
            {
                if (emp.sueldo <= media)
                {
                    empleadoMenorMedia.Add(emp);
                }
            }
            return empleadoMenorMedia;
        }
    }
    public class Empleado
    {
        public string nombre;
        public int legajo;
        public double sueldo;

        public Empleado(string nombre, int legajo, double sueldo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
    }
}
