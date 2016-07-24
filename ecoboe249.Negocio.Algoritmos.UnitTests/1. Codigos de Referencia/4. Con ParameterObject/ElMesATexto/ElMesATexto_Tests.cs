using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElMesATexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigo elCodigo;

        [TestMethod]
        public void ElMes_MesTieneUnDigitoMenos_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            elCodigo = new InformacionDelCodigo();
            elCodigo.Fecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = new Mes(elCodigo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
