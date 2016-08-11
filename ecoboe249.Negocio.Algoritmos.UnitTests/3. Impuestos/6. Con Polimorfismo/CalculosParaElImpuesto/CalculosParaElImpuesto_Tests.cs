﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto;


namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Impuesto_Tests
{
    [TestClass]
    public class CalculosParaElImpuesto_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private InformacionImpuestoSinTratamientoFiscal infoImpuestoSin;
        private InformacionImpuestoConTratamientoFiscal infoImpuestoCon;

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscal_RedondeeHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            infoImpuestoCon = new InformacionImpuestoConTratamientoFiscal();
            infoImpuestoCon.ValorFacial = 320000;
            infoImpuestoCon.ValorTransadoNeto = 300000;
            infoImpuestoCon.TasaDeImpuesto = 0.08;
            infoImpuestoCon.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuestoCon.FechaActual = new DateTime(2016, 3, 3);
            infoImpuestoCon.TieneTratamientoFiscal = true;

            elResultadoObtenido = new Impuesto(infoImpuestoCon).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.001);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_TieneTratamientoFiscalYSeDebeRedondear_RedondeeHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            infoImpuestoCon = new InformacionImpuestoConTratamientoFiscal();
            infoImpuestoCon.ValorFacial = 320500;
            infoImpuestoCon.ValorTransadoNeto = 300000;
            infoImpuestoCon.TasaDeImpuesto = 0.08;
            infoImpuestoCon.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuestoCon.FechaActual = new DateTime(2016, 3, 3);
            infoImpuestoCon.TieneTratamientoFiscal = true;

            elResultadoObtenido = new Impuesto(infoImpuestoCon).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculosParaElImpuesto_NoTieneTratamientoFiscal_ElImpuestoEsEquivalenteACero()
        {
            elResultadoEsperado = 0;

            infoImpuestoSin = new InformacionImpuestoSinTratamientoFiscal();
            infoImpuestoSin.ValorFacial = 320000;
            infoImpuestoSin.ValorTransadoNeto = 300000.0001;
            infoImpuestoSin.TasaDeImpuesto = 0.08;
            infoImpuestoSin.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuestoSin.FechaActual = new DateTime(2016, 3, 3);
            infoImpuestoSin.TieneTratamientoFiscal = false;

            elResultadoObtenido = new Impuesto(infoImpuestoSin).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}