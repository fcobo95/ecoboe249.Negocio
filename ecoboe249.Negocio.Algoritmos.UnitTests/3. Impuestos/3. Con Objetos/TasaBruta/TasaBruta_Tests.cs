using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.Impuesto_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;

        [TestMethod]
        public void TasaBruta()
        {
            elResultadoEsperado = 11.9680;

            elResutaldoObtenido = new TasaBruta(320000, 300000, 0.08, 221).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido, 0.0001);
        }
    }
}
