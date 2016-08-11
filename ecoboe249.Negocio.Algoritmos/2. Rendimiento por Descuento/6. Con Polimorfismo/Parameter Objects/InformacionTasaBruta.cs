using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public abstract class InformacionTasaBruta : InformacionDelRendimiento
    {
        public double DiasAlVencimientoComoNumero
        {
            get
            {
                return new DiasAlVencimiento(this).ComoNumero();
            }
        }

        public abstract double ValorTransadoBruto { get; }

        internal double TasaNeta()
        {
            return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                   (DiasAlVencimientoComoNumero / 365))) * 100;
        }
    }
}
