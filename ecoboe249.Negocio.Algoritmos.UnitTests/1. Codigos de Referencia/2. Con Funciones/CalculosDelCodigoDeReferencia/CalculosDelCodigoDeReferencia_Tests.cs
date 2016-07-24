using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConFunciones.CodigosDeReferencia;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConFunciones.CodigosDeReferencia_Tests
{
    [TestClass]
    public class CalculosDelCodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        
        [TestMethod]
        public void CalculeElDigitoVerificador_GeneraDosDigitosVerificadores_TrunqueAUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElNumeroDelClienteTieneMenosDigitos_PrecedaConCeros()
        {
            elResultadoEsperado = "20001111033228888888888885";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 11, 11), "33", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElNumeroDelSistemaSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20001111333028888888888884";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "2", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElMesSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20000111333228888888888885";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 1, 11), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElDiaSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20001101333228888888888883";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 11, 1), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ConsecutivoTieneMeonsDigitos()
        {
            elResultadoEsperado = "20001111333220000000000047";

            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "4");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}