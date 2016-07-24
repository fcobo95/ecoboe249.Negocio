using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;

        public Impuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elValorTransadoBruto = GenerelElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            this.elValorTransadoNeto = elValorTransadoNeto;
        }

        private static double GenerelElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
