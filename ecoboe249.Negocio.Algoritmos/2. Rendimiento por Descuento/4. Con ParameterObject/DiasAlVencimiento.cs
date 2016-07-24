using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(elRendimiento);
        }

        private static TimeSpan ObtengaLosDiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            //TODO
            return elRendimiento.FechaDeVencimiento - elRendimiento.FechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
