using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public static class CalculosParaElImpuesto
    {
        public static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            if (TieneTratamientoFiscal)
            {
                return GenereElImpuestoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            }

            else
            {
                return GenereElImpuestoSinTratamientoFiscal();
            }
        }

        private static double GenereElImpuestoConTratamientoFiscal(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ImpuestoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}

