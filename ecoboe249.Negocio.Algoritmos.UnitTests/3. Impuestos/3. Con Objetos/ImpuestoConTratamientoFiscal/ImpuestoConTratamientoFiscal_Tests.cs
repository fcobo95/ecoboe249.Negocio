using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.Impuesto_Tests
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;

        [TestMethod]
        public void ImpuestoConTratamientoFiscal()
        {
            elResultadoEsperado = 1621.6216;

            elResutaldoObtenido = new ImpuestoConTratamientoFiscal(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido);
        }
    }
}
