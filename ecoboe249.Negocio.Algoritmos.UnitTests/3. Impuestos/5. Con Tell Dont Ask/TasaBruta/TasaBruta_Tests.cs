using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.Impuesto_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        InformacionTasaBruta infoTasaBruta;

        [TestMethod]
        public void Impuestos_TasaBrutaBienFormateada_RetornaLaTasaBrutaRedondeada()
        {
            elResultadoEsperado = 11.9680;

            infoTasaBruta = new InformacionTasaBruta();
            infoTasaBruta.ValorFacial = 320000;
            infoTasaBruta.ValorTransadoNeto = 300000;
            infoTasaBruta.TasaDeImpuesto = 0.08;
            infoTasaBruta.DiasAlVencimientoComoNumero = 221;
            elResutaldoObtenido = new TasaBruta(infoTasaBruta).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido, 0.0001);
        }
    }
}
