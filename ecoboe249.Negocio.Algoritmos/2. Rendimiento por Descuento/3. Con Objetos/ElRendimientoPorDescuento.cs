using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public class ElRendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public ElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            this.elValorFacial = elValorFacial;
            elValorTransadoBruto = CalculeElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, TieneTratamientoFiscal);
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            if (TieneTratamientoFiscal)
            {
                return ObtengaElValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            }

            else
            {
                return ObtengaElValorTransadoBrutoSinTratamientoFiscal(elValorTransadoNeto);
            }
        }

        private static double ObtengaElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ElValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        private static double ObtengaElValorTransadoBrutoSinTratamientoFiscal(double elValorTransadoNeto)
        {
            return elValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
