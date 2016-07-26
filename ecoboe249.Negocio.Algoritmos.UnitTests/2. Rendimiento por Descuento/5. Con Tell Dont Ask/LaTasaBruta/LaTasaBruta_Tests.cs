using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class LaTasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionTasaBruta laTasa;

        [TestMethod]
        public void LaTasaBruta_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 11.9680;

            laTasa = new InformacionTasaBruta();
            laTasa.ValorFacial = 320000;
            laTasa.ValorTransadoNeto = 300000;
            laTasa.TasaDeImpuesto = 0.08;
            laTasa.DiasAlVencimientoComoNumero = 221;
            elResultadoObtenido = new TasaBruta(laTasa).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
