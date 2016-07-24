using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public static class CalculosParaElRendimientoPorDescuento
    {
        public static double CalculeElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual, bool TieneTratamientoFiscal)
        {
            return new RendimientoPorDescuento(elValorFacial,elValorTransadoNeto,laTasaDeImpuesto,laFechaDeVencimiento,laFechaActual, TieneTratamientoFiscal).ComoNumero();
        }
    }
}
