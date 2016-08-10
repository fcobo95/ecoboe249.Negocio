using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionTasaBruta : InformacionDelRendimiento
    {
        public double DiasAlVencimientoComoNumero { get; set; }

        internal double TasaNeta()
        {
            return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                   (DiasAlVencimientoComoNumero / 365))) * 100;
        }
    }
}
