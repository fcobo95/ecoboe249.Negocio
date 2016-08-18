namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos
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

        public abstract double Impuesto { get; }
        public abstract double ValorTransadoBruto { get; }

        internal double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                       (DiasAlVencimientoComoNumero / 365))) * 100;
            }
        }
    }
}
