﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConObjetos.CodigosDeReferencia_Tests
{
    [TestClass]
    public class LaFecha_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void LaFecha_FormateaLaFecha_RetornaUnaConcatenacionDeAñoMesYDia()
        {
            elResultadoEsperado = "20001111";

            elResultadoObtenido = new Fecha(new DateTime(2000, 11, 11)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}