using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class ValorTransadoBruto
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBruto(InformacionTasaBruta infoImpuesto)
        {
            elValorFacial = ObtengaElValorFacial(infoImpuesto);
            losDiasAlVencimientoComoNumero = infoImpuesto.DiasAlVencimientoComoNumero;
            laTasaBruta = CalculeLaTasaBruta(infoImpuesto);
        }

        private double ObtengaElValorFacial(InformacionDelRendimiento infoImpuesto)
        {
            return infoImpuesto.ValorFacial;
        }

        private static double CalculeLaTasaBruta(InformacionTasaBruta infoTasaBruta)
        {
            return new TasaBruta(infoTasaBruta).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }
    }
}
