using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto
{
    public static class CalculosParaElImpuesto
    {
        public static double CalculeElImpuesto(InformacionSobreImpuesto infoImpuesto)
        {
            if (infoImpuesto.TieneTratamientoFiscal)
            {
                return GenereElImpuestoConTratamientoFiscal(infoImpuesto);
            }

            else
            {
                return GenereElImpuestoSinTratamientoFiscal();
            }
        }

        private static double GenereElImpuestoConTratamientoFiscal(InformacionSobreImpuesto infoImpuesto)
        {
            return new ImpuestoConTratamientoFiscal(infoImpuesto).ComoNumero();
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}

