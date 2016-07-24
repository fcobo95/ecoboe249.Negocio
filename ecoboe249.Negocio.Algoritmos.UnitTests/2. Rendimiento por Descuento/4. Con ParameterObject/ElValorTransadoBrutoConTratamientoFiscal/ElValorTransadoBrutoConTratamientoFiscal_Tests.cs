using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElValorTransadoBrutoConTratamientoFiscal_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        InformacionTasaBruta laTasa;
        InformacionDelRendimiento elRendimiento;

        [TestMethod]
        public void ElValorTransadoBrutoConTratamientoFiscal_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 298378.3784;

            elRendimiento = new InformacionDelRendimiento();
            laTasa = new InformacionTasaBruta();
            laTasa.ValorFacial = 320000;
            laTasa.ValorTransadoNeto = 300000;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            laTasa.DiasAlVencimientoComoNumero = 221;
            elResultadoObtenido = new ValorTransadoBrutoConTratamientoFiscal(elRendimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
