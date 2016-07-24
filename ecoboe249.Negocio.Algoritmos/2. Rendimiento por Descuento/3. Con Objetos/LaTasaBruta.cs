namespace ecoboe249.Negocio.Algoritmos.ConObjetos.RendimientoPorDescuento
{
    public class LaTasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public LaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            this.laTasaDeImpuesto = laTasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);

        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
