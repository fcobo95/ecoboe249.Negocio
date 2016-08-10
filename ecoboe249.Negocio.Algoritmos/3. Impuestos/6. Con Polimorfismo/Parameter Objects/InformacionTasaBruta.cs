using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class InformacionTasaBruta : InformacionSobreImpuesto
    {
        public double DiasAlVencimientoComoNumero { get; set; }

        internal double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto
                    * (DiasAlVencimientoComoNumero / 365))) * 100;
            }
        }
    }
}
