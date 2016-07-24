using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElDiaATexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ElDiaATexto_ExtraElDiaComoTexto_ElDiaATextoTieneUnDigitoMenos_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            elResultadoObtenido = new Dia(new DateTime(2000, 11, 1)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
