namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.Impuesto
{
    public class TasaBruta
    {
        private double laTasaNeta;
        private double laTasaDeImpuesto;

        public TasaBruta(InformacionTasaBruta infoTasaBruta)
        {
            //TODO
            laTasaNeta = ObtengaLaTasaNeta(infoTasaBruta);
            laTasaDeImpuesto = infoTasaBruta.TasaDeImpuesto;
        }

        private static double ObtengaLaTasaNeta(InformacionTasaBruta infoTasaBruta)
        {
            //TODO
            return ((infoTasaBruta.ValorFacial - infoTasaBruta.ValorTransadoNeto) / (infoTasaBruta.ValorTransadoNeto * (infoTasaBruta.DiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
