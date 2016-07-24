using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionDelRendimiento elRendimiento;

        [TestMethod]
        public void ElRendimientoPorDescuento_CalculaElValorTransadoBruto_RetornaElValorSinTratamientoFiscal()
        {
            elResultadoEsperado = 20000;

            elRendimiento = new InformacionDelRendimiento();
            elRendimiento.ValorFacial = 320000;
            elRendimiento.ValorTransadoNeto = 300000;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elRendimiento.TieneTratamientoFiscal = true;
            elResultadoObtenido = new RendimientoPorDescuento(elRendimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
