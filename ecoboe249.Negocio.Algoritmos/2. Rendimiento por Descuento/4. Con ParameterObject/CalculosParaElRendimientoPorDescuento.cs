using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public static class CalculosParaElRendimientoPorDescuento
    {
        public static double CalculeElRendimientoPorDescuento(InformacionDelRendimiento elRendimiento)
        {
            return new RendimientoPorDescuento(elRendimiento).ComoNumero();
        }
    }
}
