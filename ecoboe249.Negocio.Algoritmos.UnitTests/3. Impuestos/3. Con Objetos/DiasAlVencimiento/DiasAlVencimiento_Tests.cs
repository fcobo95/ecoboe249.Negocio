using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.Impuesto_Tests
{
    [TestClass]
    public class DiasAlVencimiento_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;

        [TestMethod]
        public void DiasAlVencimiento_VerifiqueQueCalculeBienLosDias_RetorneLaCantidadDeDias()
        {
            elResultadoEsperado = 221;

            elResutaldoObtenido = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido);
        }
    }
}
