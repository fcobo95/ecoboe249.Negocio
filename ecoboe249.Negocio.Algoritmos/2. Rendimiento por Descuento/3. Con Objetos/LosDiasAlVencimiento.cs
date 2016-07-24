using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public class LosDiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public LosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
        }

        private static TimeSpan ObtengaLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
