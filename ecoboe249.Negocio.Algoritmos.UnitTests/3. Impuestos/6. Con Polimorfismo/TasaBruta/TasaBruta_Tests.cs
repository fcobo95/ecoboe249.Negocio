using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Impuesto_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        private InformacionImpuestoConTratamientoFiscal infoTasaBruta;

        [TestMethod]
        public void Impuestos_TasaBrutaBienFormateada_RetornaLaTasaBrutaRedondeada()
        {
            elResultadoEsperado = 11.9680;

            infoTasaBruta = new InformacionImpuestoConTratamientoFiscal();
            infoTasaBruta.ValorFacial = 320000;
            infoTasaBruta.ValorTransadoNeto = 300000;
            infoTasaBruta.TasaDeImpuesto = 0.08;
            infoTasaBruta.FechaActual = new DateTime(2016, 3, 3);
            infoTasaBruta.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoTasaBruta.TieneTratamientoFiscal = true;
            elResutaldoObtenido = new Impuesto(infoTasaBruta).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido);
        }
    }
}
