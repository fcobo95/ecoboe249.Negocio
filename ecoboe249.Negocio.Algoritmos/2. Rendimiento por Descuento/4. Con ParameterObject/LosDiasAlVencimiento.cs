using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public class LosDiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public LosDiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(elRendimiento);
        }

        private static TimeSpan ObtengaLosDiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.FechaDeVencimiento - elRendimiento.FechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
