﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class LaTasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionValorTransadoConTratamiento laTasa;

        [TestMethod]
        public void LaTasaBruta_CalculaElValorTransadoBruto_RetornaElValorConTratamientoFiscal()
        {
            elResultadoEsperado = 11.9680;

            laTasa = new InformacionValorTransadoConTratamiento();
            laTasa.ValorFacial = 320000;
            laTasa.ValorTransadoNeto = 300000;
            laTasa.TasaDeImpuesto = 0.08;
            laTasa.FechaActual = new DateTime(2016, 3, 3);
            laTasa.FechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new TasaBruta(laTasa).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
