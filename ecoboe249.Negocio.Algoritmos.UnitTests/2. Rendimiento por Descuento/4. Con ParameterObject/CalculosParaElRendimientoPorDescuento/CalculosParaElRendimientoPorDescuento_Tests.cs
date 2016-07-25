using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class CalculosParaElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionDelRendimiento elRendimiento;

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            elRendimiento = new InformacionDelRendimiento();
            elRendimiento.ValorFacial = 320000;
            elRendimiento.ValorTransadoNeto = 300000;
            elRendimiento.TasaDeImpuesto = 0.08;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elRendimiento.TieneTratamientoFiscal = true;
            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(elRendimiento);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscalYDebeRedondear_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 22159.3592;

            elRendimiento = new InformacionDelRendimiento();
            elRendimiento.ValorFacial = 320500.0000;
            elRendimiento.ValorTransadoNeto = 300000;
            elRendimiento.TasaDeImpuesto = 0.08;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elRendimiento.TieneTratamientoFiscal = true;
            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(elRendimiento);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_NoTieneTratamientoFiscal_NoRedondee()
        {
            elResultadoEsperado = 19999.9999;

            elRendimiento = new InformacionDelRendimiento();
            elRendimiento.ValorFacial = 320000.0000;
            elRendimiento.ValorTransadoNeto = 300000.0001;
            elRendimiento.TasaDeImpuesto = 0.08;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elRendimiento.TieneTratamientoFiscal = false;
            elResultadoObtenido = CalculosParaElRendimientoPorDescuento.CalculeElRendimientoPorDescuento(elRendimiento);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
