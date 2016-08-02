using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.CodigosDeReferencia_Tests
{
    [TestClass]
    public class LaFecha_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigo elCodigo;

        [TestMethod]
        public void LaFecha_FormateaLaFecha_RetornaUnaConcatenacionDeAñoMesYDia()
        {
            elResultadoEsperado = "20001111";

            elCodigo = new InformacionDelCodigo();
            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elResultadoObtenido = new Fecha(elCodigo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}