using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(InformacionSobreImpuesto infoImpuesto)
        {
            losDiasAlVencimiento = CalculeLosDiasAlVencimiento(infoImpuesto);
        }

        private static TimeSpan CalculeLosDiasAlVencimiento(InformacionSobreImpuesto infoImpuesto)
        {
            return infoImpuesto.DiasAlVencimiento();
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
