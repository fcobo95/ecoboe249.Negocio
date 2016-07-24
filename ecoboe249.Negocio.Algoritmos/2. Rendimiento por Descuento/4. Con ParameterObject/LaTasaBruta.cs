namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public class LaTasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public LaTasaBruta(InformacionTasaBruta laTasa)
        {
            laTasaDeImpuesto = laTasa.TasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(laTasa);

        }

        private static double CalculeLaTasaNeta(InformacionTasaBruta laTasa)
        {
            return ((laTasa.ValorFacial - laTasa.ValorTransadoNeto) / (laTasa.ValorTransadoNeto * (laTasa.DiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
