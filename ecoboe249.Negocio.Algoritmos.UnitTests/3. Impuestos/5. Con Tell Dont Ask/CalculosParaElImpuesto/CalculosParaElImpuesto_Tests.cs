using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.Impuesto_Tests
{
    [TestClass]
    public class CalculosParaElImpuesto_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private InformacionSobreImpuesto infoImpuesto;

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscal_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            infoImpuesto = new InformacionSobreImpuesto();
            infoImpuesto.ValorFacial = 320000;
            infoImpuesto.ValorTransadoNeto = 300000;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);
            infoImpuesto.TieneTratamientoFiscal = true;
            
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(infoImpuesto);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscalYSeDebeRedondear_RedondeeHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            infoImpuesto = new InformacionSobreImpuesto();
            infoImpuesto.ValorFacial = 320500;
            infoImpuesto.ValorTransadoNeto = 300000;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);
            infoImpuesto.TieneTratamientoFiscal = true;
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(infoImpuesto);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_NoTieneTratamientoFiscal_ElImpuestoEsEquivalenteACero()
        {
            elResultadoEsperado = 0;

            infoImpuesto = new InformacionSobreImpuesto();
            infoImpuesto.ValorFacial = 320000;
            infoImpuesto.ValorTransadoNeto = 300000.0001;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);
            infoImpuesto.TieneTratamientoFiscal = false;
            elResultadoObtenido = CalculosParaElImpuesto.CalculeElImpuesto(infoImpuesto);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
