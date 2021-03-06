﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuestos;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.Impuesto_Tests
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Tests
    {
        private double elResultadoEsperado;
        private double elResutaldoObtenido;
        private InformacionValorTransadoConTratamiento infoImpuesto;

        [TestMethod]
        public void ImpuestoConTratamientoFiscal()
        {
            elResultadoEsperado = 1621.6216;

            infoImpuesto = new InformacionValorTransadoConTratamiento();
            infoImpuesto.ValorFacial = 320000;
            infoImpuesto.ValorTransadoNeto = 300000;
            infoImpuesto.TasaDeImpuesto = 0.08;
            infoImpuesto.FechaDeVencimiento = new DateTime(2016, 10, 10);
            infoImpuesto.FechaActual = new DateTime(2016, 3, 3);
            elResutaldoObtenido = new ImpuestoConTratamientoFiscal(infoImpuesto).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResutaldoObtenido);
        }
    }
}
