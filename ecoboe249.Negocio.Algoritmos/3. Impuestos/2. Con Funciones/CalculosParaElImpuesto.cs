using System;

namespace ecoboe249.Negocio.Algoritmos.ConFunciones.Impuesto
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
            double elImpuesto = CalculeElImpuesto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);

            return CalculeElImpuestoConTratamientoFiscal(elImpuesto);
        }

        private static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double elValorTransadoBruto = GenerelElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);

            return CalculeElValorDelImpuesto(elValorTransadoNeto, elValorTransadoBruto);
        }

        private static double GenerelElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            double laTasaBruta = CalculeLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);

            return CalculeElValorTransadoBruto(elValorFacial, losDiasAlVencimientoComoNumero, laTasaBruta);
        }

        private static double GenereLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            TimeSpan losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);

            return ExtraigaLosDias(losDiasAlVencimiento);
        }

        private static TimeSpan CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        private static double ExtraigaLosDias(TimeSpan losDiasAlVencimiento)
        {
            return losDiasAlVencimiento.Days;
        }

        private static double CalculeLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            double laTasaNeta = ObtengaLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);

            return ObtengaLaTasaBruta(laTasaDeImpuesto, laTasaNeta);
        }

        private static double ObtengaLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        private static double ObtengaLaTasaBruta(double laTasaDeImpuesto, double laTasaNeta)
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial, double losDiasAlVencimientoComoNumero, double laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }

        private static double CalculeElValorDelImpuesto(double elValorTransadoNeto, double elValorTransadoBruto)
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }

        private static double CalculeElImpuestoConTratamientoFiscal(double elImpuesto)
        {
            return Math.Round(elImpuesto, 4);
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}

