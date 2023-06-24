using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemaXd2
    {
        //Problema:
        //Imagina que estás desarrollando un juego de rol(RPG) y necesitas implementar un sistema para administrar los
        //inventarios de los personajes.Crea las clases necesarias para modelar este sistema y luego implementa un algoritmo
        //para encontrar el artículo más caro en el inventario de un personaje.

        //Crea una clase llamada "Articulo" que tenga las siguientes propiedades:

        //Nombre: una cadena que indica el nombre del artículo.
        //Precio: un número decimal que indica el precio del artículo.

        //Crea una clase llamada "Personaje" que tenga las siguientes propiedades:

        //Nombre: una cadena que indica el nombre del personaje.
        //Inventario: una lista de objetos "Articulo" que representa el inventario del personaje.
        //Implementa un método en la clase "Personaje" llamado "EncontrarArticuloMasCaro" que no reciba ningún parámetro
        //y devuelva el artículo más caro en el inventario del personaje. Si el inventario está vacío, el método debe
        //devolver null.

        //Tu tarea es implementar las clases "Articulo" y "Personaje" según las especificaciones dadas y
        //luego implementar el método "EncontrarArticuloMasCaro" en la clase "Personaje".

        //Tiempo estimado: 30 minutos
    }

    public class Personaje
    {
        private string _nombre;
        public List<Articulo> _inventario = new List<Articulo>();

        public string nombre 
        { 
            get { return _nombre; } 
            set { _nombre = value; } 
        }

        public Articulo EncontrarArticuloMasCaro()
        {
            if (_inventario.Count == 0)
            {
                return null;
            }

            Articulo articuloMasCaro = new Articulo();

            foreach(Articulo articulo in _inventario) 
            {
                if (articulo.precio > articuloMasCaro.precio)
                {
                    articuloMasCaro = articulo;
                }
            }

            return articuloMasCaro;
        }
    }

    public class Articulo
    {
        private string _nombre;
        private decimal _precio;

        public string nombre { 
            get { return this._nombre; } 
            set { this._nombre = value; } 
        } 
        public decimal precio {
            get { return this._precio; }
            set { this._precio = value; }
        }
    }
}
