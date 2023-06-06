using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2023.TPN4
{
    internal class Circulo : Figura
    {
        public double Area(params double[] parametros)
        {
            return Math.PI * parametros[0] * parametros[0];
        }
    }
}
