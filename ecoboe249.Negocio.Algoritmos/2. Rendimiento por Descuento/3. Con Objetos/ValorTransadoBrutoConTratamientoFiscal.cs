using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorFacial = elValorFacial;
            losDiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            laTasaBruta = CalculeLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);
        }

        private static double CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new DiasAlVencimiento(laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        private static double CalculeLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            return new TasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }
    }
}
