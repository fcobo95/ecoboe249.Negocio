using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConFunciones.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConFunciones.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class CalculosParaElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(320000.0000,
                300000.0000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscalYDebeRedondear_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 22159.3592;

            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(320500.0000,
                300000.0000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_NoTieneTratamientoFiscal_NoRedondee()
        {
            elResultadoEsperado = 19999.9999;

            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(320000.0000,
                300000.0001, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), false);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
