using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaXd2
    {
        /*
        Problema:
            Imagina que estás desarrollando un videojuego y necesitas implementar un sistema de inventario. 
            Crea las clases y interfaces necesarias para modelar este sistema.

            Crea una clase llamada "Item" que represente un artículo del inventario. 
            Esta clase debe tener las siguientes propiedades:

            Nombre: una cadena que indica el nombre del artículo.
            Peso: un número entero que indica el peso del artículo.
            
            Crea una interfaz llamada "IUsable" que tenga un método llamado "Usar". 
                Este método no debe tener ningún parámetro y no debe devolver ningún valor.

            Crea una enumeración llamada "ItemType" que contenga los siguientes valores:

            Arma
            Armadura
            Consumible

            Crea una clase llamada "Weapon" que herede de "Item" e implemente la interfaz "IUsable". 
            Esta clase debe tener una propiedad adicional llamada "Damage" que representa el daño que puede infligir el arma.

            Crea una clase llamada "Armor" que herede de "Item". 
            Esta clase debe tener una propiedad adicional llamada "Defense" que representa la defensa que proporciona la armadura.

            Crea una clase llamada "Consumable" que herede de "Item" e implemente la interfaz "IUsable". 
            Esta clase debe tener una propiedad adicional llamada "HealthRestore" que representa la cantidad de 
            salud que restaura el consumible.

            Tu tarea es implementar las clases, la interfaz y la enumeración según las especificaciones dadas. 
            Asegúrate de que las clases hereden correctamente, implementen las propiedades y métodos necesarios, 
            y utilicen los tipos y nombres correctos.

            Tiempo estimado: 30 minutos
        */
    }
    public class Item
    {
        private string _nombre;
        private int _peso;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Peso { get { return _peso; } set { _peso = value; } }
    }

    public interface IUsable
    {
        public void Usar();
    }

    public enum ItemType
    {
        Arma,
        Armadura,
        Consumible
    }

    public class Weapon : Item, IUsable
    {
        private int _damage;

        public int Damage { get { return _damage; } set { _damage = value; } }

        public void Usar()
        {
            throw new NotImplementedException();
        }
    }

    public class Armor : Item
    {
        private int _defense;

        public int Defense { get { return _defense;} set { _defense = value; } }

    }

    public class Consumible : Item, IUsable
    {
        private int _healtRestore;

        public int HealtRestore { get { return _healtRestore; } set { _healtRestore = value; }  }  

        public void Usar()
        {
            throw new NotImplementedException();
        }
    }
}
