using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElAño_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ElAño_SeExtraeComoTexto_RetornaUnStringConCuatroCaracteresNumericos()
        {
            elResultadoEsperado = "2000";

            elResultadoObtenido = new Año(new DateTime(2000, 11, 11)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
