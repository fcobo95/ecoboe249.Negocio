using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.Impuesto_Tests
{
    [TestClass]
    public class CalculosParaElImpuesto_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscal_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscalYSeDebeRedondear_RedondeeHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(320500, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_NoTieneTratamientoFiscal_ElImpuestoEsEquivalenteACero()
        {
            elResultadoEsperado = 0;
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(320000, 300000.0001, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), false);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
