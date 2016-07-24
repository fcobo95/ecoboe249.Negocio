using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class LaTasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void LaTasaBruta_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 11.9680;

            elResultadoObtenido = new TasaBruta(320000, 300000, 0.08,221).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
