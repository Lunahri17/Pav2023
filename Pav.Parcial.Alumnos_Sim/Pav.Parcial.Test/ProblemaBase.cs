using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pav.Parcial;
using Pav.Parcial.Library;

namespace PavParcial.Test
{
    [TestClass]
    public partial class ProblemasTest : EnsambladoTestBase
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            IniciarGeneral(typeof(Datos), Datos.Host);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [ClassCleanup]
        public static void Cleanup()
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            
        }
    }
}
