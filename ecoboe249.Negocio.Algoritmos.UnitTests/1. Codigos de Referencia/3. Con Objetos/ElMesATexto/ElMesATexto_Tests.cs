using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElMesATexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ElMes_MesTieneUnDigitoMenos_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            elResultadoObtenido = new Mes(new DateTime(2000, 1, 11)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
