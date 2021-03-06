﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConTellDontAsk.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ElValorTransadoBrutoConTratamientoFiscal_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        InformacionDelRendimiento elRendimiento;

        [TestMethod]
        public void ElValorTransadoBrutoConTratamientoFiscal_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 298378.3784;

            elRendimiento = new InformacionDelRendimiento();
            elRendimiento.ValorFacial = 320000;
            elRendimiento.ValorTransadoNeto = 300000;
            elRendimiento.TasaDeImpuesto = 0.08;
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ValorTransadoBrutoConTratamientoFiscal(elRendimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
