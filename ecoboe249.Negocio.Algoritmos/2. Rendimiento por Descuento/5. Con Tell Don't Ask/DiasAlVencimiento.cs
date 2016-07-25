using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento
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
            //TODO Mas de una operacion
            return elRendimiento.FechaDeVencimiento - elRendimiento.FechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
