using System;

namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.Impuesto
{
    public static class CalculosParaElImpuesto
    {
        public static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            double elImpuestoFinal;
            if (TieneTratamientoFiscal)
            {
                TimeSpan losDiasAlVencimiento;
                losDiasAlVencimiento = laFechaDeVencimiento - laFechaActual;

                double losDiasAlVencimientoComoNumero;
                losDiasAlVencimientoComoNumero = losDiasAlVencimiento.Days;

                double laTasaNeta;
                laTasaNeta = ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;

                double laTasaBruta;
                laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);

                double elValorTransadoBruto;
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));

                double elImpuesto;
                elImpuesto = elValorTransadoNeto - elValorTransadoBruto;

                elImpuestoFinal = Math.Round(elImpuesto, 4);
            }

            else
            {
                elImpuestoFinal = 0;
            }

            return elImpuestoFinal;
        }
    }
}

