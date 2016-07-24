using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
        }

        private static TimeSpan CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
