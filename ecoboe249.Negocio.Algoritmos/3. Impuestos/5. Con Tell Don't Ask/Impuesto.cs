using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;

        public Impuesto(InformacionSobreImpuesto infoImpuesto)
        {
            elValorTransadoBruto = GenerelElValorTransadoBruto(infoImpuesto);
            elValorTransadoNeto = ObtengaelValorTransadoNeto(infoImpuesto);
        }

        private double ObtengaelValorTransadoNeto(InformacionSobreImpuesto infoImpuesto)
        {
            return infoImpuesto.ValorTransadoNeto;
        }

        private static double GenerelElValorTransadoBruto(InformacionSobreImpuesto infoImpuesto)
        {
            return new ValorTransadoBruto(infoImpuesto).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
