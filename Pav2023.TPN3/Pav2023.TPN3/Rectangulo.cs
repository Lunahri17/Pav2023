using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2023.TPN3
{
    internal class Rectangulo : Figura
    {
        public override double Area(params double[] parametros)
        {
            return parametros[0] * parametros[1];
        }
    }
}
