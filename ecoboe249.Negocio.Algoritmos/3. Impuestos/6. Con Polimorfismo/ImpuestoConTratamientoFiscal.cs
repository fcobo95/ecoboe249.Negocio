using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elImpuesto;

        public ImpuestoConTratamientoFiscal(InformacionSobreImpuesto infoImpuesto)
        {
            elImpuesto = CalculeElImpuesto(infoImpuesto);
        }

        private static double CalculeElImpuesto(InformacionSobreImpuesto infoImpuesto)
        {
            return new Impuesto(infoImpuesto).ComoNumero();
        }

        public double ComoNumero()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
