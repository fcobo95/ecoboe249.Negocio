using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConParameterObject.CodigosDeReferencia_Tests
{
    [TestClass]
    public class CalculosDelCodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigo elCodigo;

        [TestMethod]
        public void CalculeElDigitoVerificador_GeneraDosDigitosVerificadores_TrunqueAUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            elCodigo = new InformacionDelCodigo();
            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elCodigo.NumeroDelCliente = "333";
            elCodigo.NumeroDelSistema = "22";
            elCodigo.NumeroDelConsecutivo = "888888888888";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElNumeroDelClienteTieneMenosDigitos_PrecedaConCeros()
        {
            elResultadoEsperado = "20001111033228888888888885";
            elCodigo = new InformacionDelCodigo();

            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elCodigo.NumeroDelCliente = "33";
            elCodigo.NumeroDelSistema = "22";
            elCodigo.NumeroDelConsecutivo = "888888888888";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElNumeroDelSistemaSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20001111333028888888888884";
            elCodigo = new InformacionDelCodigo();

            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elCodigo.NumeroDelCliente = "333";
            elCodigo.NumeroDelSistema = "2";
            elCodigo.NumeroDelConsecutivo = "888888888888";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElMesSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20000111333228888888888885";
            elCodigo = new InformacionDelCodigo();

            elCodigo.Fecha = new DateTime(2000, 1, 11);
            elCodigo.NumeroDelCliente = "333";
            elCodigo.NumeroDelSistema = "22";
            elCodigo.NumeroDelConsecutivo = "888888888888";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ElDiaSoloTieneUnDigito_PrecedaConCeros()
        {
            elResultadoEsperado = "20001101333228888888888883";
            elCodigo = new InformacionDelCodigo();

            elCodigo.Fecha = new DateTime(2000, 11, 1);
            elCodigo.NumeroDelCliente = "333";
            elCodigo.NumeroDelSistema = "22";
            elCodigo.NumeroDelConsecutivo = "888888888888";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElDigitoVerificador_ConsecutivoTieneMeonsDigitos()
        {
            elResultadoEsperado = "20001111333220000000000047";
            elCodigo = new InformacionDelCodigo();

            elCodigo.Fecha = new DateTime(2000, 11, 11);
            elCodigo.NumeroDelCliente = "333";
            elCodigo.NumeroDelSistema = "22";
            elCodigo.NumeroDelConsecutivo = "4";
            elResultadoObtenido = CalculosDelCodigoDeReferencia.CalculeElCodigoDeReferencia(elCodigo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}