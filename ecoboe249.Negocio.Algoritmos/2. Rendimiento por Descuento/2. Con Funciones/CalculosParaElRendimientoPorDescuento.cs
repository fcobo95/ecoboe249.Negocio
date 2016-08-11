using System;

namespace ecoboe249.Negocio.Algoritmos.ConFunciones.RendimientoPorDescuento
{
    public static class CalculosParaElRendimientoPorDescuento
    {
        public static double CalculeElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            double elValorTransadoBruto = CalculeElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, TieneTratamientoFiscal);

            return GenereElRendimientoPorDescuentoCalculado(elValorFacial, elValorTransadoBruto);
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            if (TieneTratamientoFiscal)
                return CalculeElValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            else
                return CalculeElValorTransadoBrutoSinTratamientoFiscal(elValorTransadoNeto);
        }

        private static double CalculeElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            double laTasaBruta = CalculeLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);

            return CalculeElValorTransadoBrutoConTratamientoFiscal(elValorFacial, losDiasAlVencimientoComoNumero, laTasaBruta);
        }

        private static double CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            TimeSpan losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);

            return ExtraigaLosDias(losDiasAlVencimiento);
        }

        private static TimeSpan ObtengaLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        private static double ExtraigaLosDias(TimeSpan losDiasAlVencimiento)
        {
            return losDiasAlVencimiento.Days;
        }

        private static double CalculeLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            double laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);

            return ObtengaLaTasaBruta(laTasaDeImpuesto, laTasaNeta);
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        private static double ObtengaLaTasaBruta(double laTasaDeImpuesto, double laTasaNeta)
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }

        private static double CalculeElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double losDiasAlVencimientoComoNumero, double laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }

        private static double CalculeElValorTransadoBrutoSinTratamientoFiscal(double elValorTransadoNeto)
        {
            return elValorTransadoNeto;
        }

        private static double GenereElRendimientoPorDescuentoCalculado(double elValorFacial, double elValorTransadoBruto)
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
