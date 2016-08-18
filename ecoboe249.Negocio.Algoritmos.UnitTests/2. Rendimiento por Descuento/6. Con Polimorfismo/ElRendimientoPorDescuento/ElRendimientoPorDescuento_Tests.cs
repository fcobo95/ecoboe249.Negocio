using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionValorTransadoSinTratamiento elRendimiento;
        private InformacionValorTransadoConTratamiento elRendimientoCon;

        [TestMethod]
        public void ElRendimientoPorDescuento_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 21621.6216;

            elRendimientoCon = new InformacionValorTransadoConTratamiento();
            elRendimientoCon.ValorFacial = 320000;
            elRendimientoCon.ValorTransadoNeto = 300000;
            elRendimientoCon.TasaDeImpuesto = 0.08;
            elRendimientoCon.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimientoCon.FechaActual = new DateTime(2016, 3, 3);
            elRendimientoCon.TieneTratamientoFiscal = true;
            elResultadoObtenido = new RendimientoPorDescuentoReal(elRendimientoCon).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void ElRendimientoPorDescuento_CalculaElValorTransadoBrutoSinTratamiento_RetornaElValorSinTratamientoFiscal()
        {
            elResultadoEsperado = 20000;

            elRendimiento = new InformacionValorTransadoSinTratamiento();
            elRendimiento.ValorFacial = 320000;
            elRendimiento.ValorTransadoNeto = 300000;
            elRendimiento.TasaDeImpuesto = 0.08;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elRendimiento.TieneTratamientoFiscal = false;
            elResultadoObtenido = new RendimientoPorDescuentoReal(elRendimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
