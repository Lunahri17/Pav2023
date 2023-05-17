using System.Diagnostics;
using Pav.Parcial.Library;

namespace Pav.Parcial
{
    public abstract class ProblemaBase: IEvaluador
    {
        public void MostrarError(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            Debug.WriteLine(mensaje);
            Debug.Flush();
        }
    }
}
