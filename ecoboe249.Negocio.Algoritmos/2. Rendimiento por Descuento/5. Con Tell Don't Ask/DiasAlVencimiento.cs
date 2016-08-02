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
            return elRendimiento.DiasAlVencimiento();
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
