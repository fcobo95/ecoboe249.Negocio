using System;

namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.RendimientoPorDescuento
{
    public static class CalculosParaElRendimientoPorDescuento
    {
        public static double CalculeElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            double elValorTransadoBruto;
            if (TieneTratamientoFiscal)
            {
                TimeSpan losDiasAlVencimiento = laFechaDeVencimiento - laFechaActual;

                double losDiasAlVencimientoComoNumero = losDiasAlVencimiento.Days;

                double laTasaNeta = ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;

                double laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);

                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
            }

            else
            {
                elValorTransadoBruto = elValorTransadoNeto;
            }

            double elRendimientoPorDescuento;
            elRendimientoPorDescuento = elValorFacial - elValorTransadoBruto;

            return elRendimientoPorDescuento;
        }
    }
}
