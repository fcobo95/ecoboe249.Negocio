using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.GeneracionDeInversiones;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Inversiones_Tests
{
    [TestClass]
    public class FechaDeVencimiento_Tests
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;
        private NuevaInversion laInversion;

        [TestMethod]
        public void GeneracionDeInversiones_ReviseLaFechaDeVencimiento_RetorneLaFechaDeVencimiento()
        {
            elResultadoEsperado = new DateTime(2016, 3, 3);

            laInversion = GeneradorDeInversiones.GenereUnaNuevaInversion(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true, "888888888888");

            elResultadoObtenido = laInversion.FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
