using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Impuesto_Tests
{
    [TestClass]
    public class ValorTransadoBruto_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        private InformacionImpuestoConTratamientoFiscal infoImpuesto;

        [TestMethod]
        public void ValorTransadoBruto()
        {
            elResultadoEsperado = 298378.3784;

            infoImpuesto = new InformacionImpuestoConTratamientoFiscal();
            infoImpuesto.ValorFacial = 320000;
            infoImpuesto.ValorTransadoNeto = 300000;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);
            elResutaldoObtenido = new ValorTransadoBruto(infoImpuesto).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido, 0.0001);
        }
    }
}
