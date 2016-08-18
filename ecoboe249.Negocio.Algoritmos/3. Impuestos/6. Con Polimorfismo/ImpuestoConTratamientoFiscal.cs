using System;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuestos
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elImpuesto;

        public ImpuestoConTratamientoFiscal(InformacionTasaBruta infoImpuesto)
        {
            elImpuesto = CalculeElImpuesto(infoImpuesto);
        }

        private static double CalculeElImpuesto(InformacionTasaBruta infoImpuesto)
        {
            return new Impuesto(infoImpuesto).ComoNumero();
        }

        public double ComoNumero()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
