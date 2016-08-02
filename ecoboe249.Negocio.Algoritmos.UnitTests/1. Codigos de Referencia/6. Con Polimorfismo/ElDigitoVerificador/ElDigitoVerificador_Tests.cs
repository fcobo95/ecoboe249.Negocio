using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.CodigosDeReferencia_Tests
{
    [TestClass]
    public class ElDigitoVerificador_Tests
    {
        private string elRequerimiento;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ElDigitoVerificador_RequerimientoDevuelveUno_RequerimientoCorrecto()
        {
            elResultadoEsperado = "1";

            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new DigitoVerificador(elRequerimiento).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ElDigitoVerificador_RequerimientoDevuelveUnNumeroMayorQueUno_RequerimientoCorrecto()
        {
            elResultadoEsperado = "5";

            elRequerimiento = "2000111103322888888888888";
            elResultadoObtenido = new DigitoVerificador(elRequerimiento).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
