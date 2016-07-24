using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.Impuesto_Tests
{
    [TestClass]
    public class ValorTransadoBruto_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;

        [TestMethod]
        public void ValorTransadoBruto()
        {
            elResultadoEsperado = 298378.3784;

            elResutaldoObtenido = new ValorTransadoBruto(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido, 0.0001);
        }
    }
}
