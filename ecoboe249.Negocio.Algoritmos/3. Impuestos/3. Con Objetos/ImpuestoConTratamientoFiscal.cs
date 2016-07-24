using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elImpuesto;

        public ImpuestoConTratamientoFiscal(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elImpuesto = CalculeElImpuesto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
        }

        private static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new Impuesto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        public double ComoNumero()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
