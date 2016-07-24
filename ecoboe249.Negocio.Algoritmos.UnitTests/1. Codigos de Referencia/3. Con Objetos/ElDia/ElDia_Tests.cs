using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElDia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ElDia_ExtraElDia_RetornUnStringDeDosCaracteresNumericos()
        {
            elResultadoEsperado = "11";

            elResultadoObtenido = new Dia(new DateTime(2000, 11, 11)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
