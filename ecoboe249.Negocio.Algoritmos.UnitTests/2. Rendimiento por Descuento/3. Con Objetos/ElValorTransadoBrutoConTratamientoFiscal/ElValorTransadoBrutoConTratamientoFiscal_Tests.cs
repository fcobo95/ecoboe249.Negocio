using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElValorTransadoBrutoConTratamientoFiscal_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ElValorTransadoBrutoConTratamientoFiscal_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 298378.3784;

            elResultadoObtenido = new ValorTransadoBrutoConTratamientoFiscal(320000, 300000, 0.08, new DateTime(2016,10,10), new DateTime(2016,3,3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
