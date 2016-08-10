using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionDelRendimiento
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool TieneTratamientoFiscal { get; set; }

        public double ValorTransadoBruto
        {
            get
            {
                if (TieneTratamientoFiscal)
                    return ValorTransadoBrutoConTratamientoFiscal();
                else
                    return ValorTransadoBrutoSinTratamientoFiscal();
            }
        }

        private double ValorTransadoBrutoConTratamientoFiscal()
        {
            return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
        }

        private double ValorTransadoBrutoSinTratamientoFiscal()
        {
            return ValorTransadoNeto;
        }

        internal TimeSpan DiasAlVencimiento
        {
            get
            {
                return FechaDeVencimiento - FechaActual;
            }
        }
    }
}
