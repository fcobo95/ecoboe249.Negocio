namespace ecoboe249.Negocio.Algoritmos.ConObjetos.Impuesto
{
    public class TasaBruta
    {
        private double laTasaNeta;
        private double laTasaDeImpuesto;

        public TasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            laTasaNeta = ObtengaLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);
            this.laTasaDeImpuesto = laTasaDeImpuesto;
        }

        private static double ObtengaLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
