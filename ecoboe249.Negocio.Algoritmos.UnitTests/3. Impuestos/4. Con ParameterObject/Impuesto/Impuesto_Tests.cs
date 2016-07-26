using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.Impuesto_Tests
{
    [TestClass]
    public class Impuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        private InformacionSobreImpuesto infoImpuesto;

        [TestMethod]
        public void Impuesto_TasaBrutaBienFormateada_RetornaLaTasaRedondeada()
        {
            elResultadoEsperado = 1621.6216;

            infoImpuesto = new InformacionSobreImpuesto();
            infoImpuesto.ValorFacial = 320000;
            infoImpuesto.ValorTransadoNeto = 300000;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);

            elResutaldoObtenido = new Impuesto(infoImpuesto).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido, 0.0001);
        }
    }
}
