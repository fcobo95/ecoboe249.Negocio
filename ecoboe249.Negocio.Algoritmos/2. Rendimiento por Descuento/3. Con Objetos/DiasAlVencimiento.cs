using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
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
