using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;

namespace ecoboe249.Negocio.Algoritmos.UnitTests.ConPolimorfismo.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class DiasAlVencimiento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private InformacionValorTransadoConTratamiento elRendimiento;

        [TestMethod]
        public void LosDiasAlVencimiento_ExtraeLosDiasAlVencimiento_RetornaLaCantidadDeDias()
        {
            elResultadoEsperado = 221;

            elRendimiento = new InformacionValorTransadoConTratamiento();
            elRendimiento.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elRendimiento.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new DiasAlVencimiento(elRendimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
