using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class DiasAlVencimiento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void LosDiasAlVencimiento_ExtraeLosDiasAlVencimiento_RetornaLaCantidadDeDias()
        {
            elResultadoEsperado = 221;

            elResultadoObtenido = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
