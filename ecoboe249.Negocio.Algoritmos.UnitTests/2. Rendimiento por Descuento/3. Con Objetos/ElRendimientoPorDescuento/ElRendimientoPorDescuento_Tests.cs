using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ElRendimientoPorDescuento_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 21621.6216;

            elResultadoObtenido = new RendimientoPorDescuento(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
