﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.ValidacionesImpuesto;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Validaciones_Tests
{
    [TestClass]
    public class Validaciones_Tests
    {
        private bool elResultadoObtenido;
        private bool elResultadoEspeardo;
        private InformacionValidaciones lasValidaciones;

        [TestMethod]
        public void ValidacionesParaElImpuesto_ValorFacialEsMenorQueCienMil_RetorneFalso()
        {
            elResultadoEspeardo = false;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100000;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 0.08;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_ValorTransadoNetoEsMenorQueCienMil_RetorneFalso()
        {
            elResultadoEspeardo = false;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100000;
            lasValidaciones.TasaDeImpuesto = 0.08;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEsMayorQueCero_RetorneFalso()
        {
            elResultadoEspeardo = false;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 0;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEsMenorQueUno_RetorneFalso()
        {
            elResultadoEspeardo = false;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 1;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_LaTasaDeImpuestoEstaEntreCeroYUno_RetorneVerdadero()
        {
            elResultadoEspeardo = true;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 0.08;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_FechaActualEsMayorQueLaDeVencimiento_RetorneFalso()
        {
            elResultadoEspeardo = false;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 0.08;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 3, 3);
            lasValidaciones.FechaActual = new DateTime(2016, 10, 10);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionesParaElImpuesto_TodosLosParametrosSonVerdaderos_RetorneVerdadero()
        {
            elResultadoEspeardo = true;

            lasValidaciones = new InformacionValidaciones();
            lasValidaciones.ValorFacial = 100001;
            lasValidaciones.ValorTransadoNeto = 100001;
            lasValidaciones.TasaDeImpuesto = 0.08;
            lasValidaciones.FechaDeVencimiento = new DateTime(2016, 10, 10);
            lasValidaciones.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Validaciones(lasValidaciones).ValideQueSeaCierto();

            Assert.AreEqual(elResultadoEspeardo, elResultadoObtenido);
        }
    }
}
