using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento
{
    public class InformacionTasaBruta
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public double DiasAlVencimientoComoNumero { get; set; }

        internal double CalculeLaTasaNeta()
        {
            return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                   (DiasAlVencimientoComoNumero / 365))) * 100;
        }
    }
}
