using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElDiaATexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigo elCodigo;

        [TestMethod]
        public void ElDiaATexto_ExtraElDiaComoTexto_ElDiaATextoTieneUnDigitoMenos_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            elCodigo = new InformacionDelCodigo();
            elCodigo.Fecha = new DateTime(2000, 11, 1);
            elResultadoObtenido = new Dia(elCodigo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
