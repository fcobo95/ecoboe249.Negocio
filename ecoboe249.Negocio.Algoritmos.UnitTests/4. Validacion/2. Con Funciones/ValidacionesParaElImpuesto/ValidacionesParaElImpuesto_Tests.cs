using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConFunciones.ValidacionesImpuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConFunciones.Validaciones_Tests
{
    [TestClass]
    public class ValidacionesParaElImpuesto_Tests
    {
        private object elResultadoObtenido;
        private bool elResultadoEspeardo;

        [TestMethod]
        public void ValidacionesParaElImpuesto_ValorFacialEsMenorQueCienMil_RetorneFalso()
        {
            elResultadoEspeardo = false;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100000, 100001,
                0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_ValorTransadoNetoEsMenorQueCienMil_RetorneFalso()
        {
            elResultadoEspeardo = false;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100000,
                0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEsMayorQueCero_RetorneFalso()
        {
            elResultadoEspeardo = false;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100001,
                0, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEsMenorQueUno_RetorneFalso()
        {
            elResultadoEspeardo = false;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100001,
                1, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEstaEntreCeroYUno_RetorneVerdadero()
        {
            elResultadoEspeardo = true;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100001,
                0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_FechaActualEsMayorQueLaDeVencimiento_RetorneFalso()
        {
            elResultadoEspeardo = false;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100001,
                0.08, new DateTime(2016, 3, 3), new DateTime(2016, 10, 10));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_TodosLosParametrosSonVerdaderos_RetorneVerdadero()
        {
            elResultadoEspeardo = true;
            elResultadoObtenido = ValidacionesParaElImpuesto.Validaciones(100001, 100001,
                0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3));

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }
    }
}
