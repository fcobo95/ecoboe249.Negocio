using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElMes_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigo elCodigo;

        [TestMethod]
        public void ElMes_ExtraeElMes_RetornaUnStringDeDosCaracteresNumericos()
        {
            elResultadoEsperado = "11";

            elCodigo = new InformacionDelCodigo();
            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elResultadoObtenido = new Mes(elCodigo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
