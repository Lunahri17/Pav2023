using Pav.Parcial.Library;
using System;

namespace Pav.Parcial.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PavParcialManager.Iniciar(typeof(Datos), Datos.Host);
        }
    }
}
