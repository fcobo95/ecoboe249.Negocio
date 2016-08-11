using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Impuesto_Tests
{
    [TestClass]
    public class DiasAlVencimiento_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        private InformacionImpuestoConTratamientoFiscal infoImpuesto;

        [TestMethod]
        public void DiasAlVencimiento_VerifiqueQueCalculeBienLosDias_RetorneLaCantidadDeDias()
        {
            elResultadoEsperado = 221;

            infoImpuesto = new InformacionImpuestoConTratamientoFiscal();
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);

            elResutaldoObtenido = new DiasAlVencimiento(infoImpuesto).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido);
        }
    }
}
