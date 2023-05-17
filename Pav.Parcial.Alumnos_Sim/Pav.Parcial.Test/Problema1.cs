using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pav.Parcial.Library;

namespace Pav.Parcial.Test
{
    [TestClass]
    public partial class ProblemaTest1 : ProblemaTestBase<Problema1>
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            Iniciar();
        }

        [TestMethod]
        public void Test1()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test2()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test3()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test4()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test5()
        {
            Evaluar();
        }
    }
}
