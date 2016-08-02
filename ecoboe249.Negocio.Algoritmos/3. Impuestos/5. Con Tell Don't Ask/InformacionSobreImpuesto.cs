using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto
{
    public class InformacionSobreImpuesto
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool TieneTratamientoFiscal { get; set; }

        public double Impuesto
        {
            get
            {
                if (TieneTratamientoFiscal)
                    return ImpuestoConTratamientoFiscal();
                else
                    return ImpuestoSinTratamientoFiscal();
            }
        }


        internal TimeSpan DiasAlVencimiento()
        {
            return FechaDeVencimiento - FechaActual;
        }

        private double ImpuestoConTratamientoFiscal()
        {
            return new ImpuestoConTratamientoFiscal(this).ComoNumero();
        }

        private double ImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}
