using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public class ValorTransadoBruto
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            laTasaBruta = CalculeLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);
            this.elValorFacial = elValorFacial;
        }

        private static double GenereLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
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
