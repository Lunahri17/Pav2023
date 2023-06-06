using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2023.TPN4
{
    internal class Triangulo : Figura
    {
        public double Area(params double[] parametros)
        {
            return (parametros[0] * parametros[1]) / 2;
        }
    }
}
