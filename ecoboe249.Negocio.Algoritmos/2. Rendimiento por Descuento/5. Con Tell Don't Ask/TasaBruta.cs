namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(InformacionTasaBruta laTasa)
        {
            //TODO Detalles
            laTasaDeImpuesto = laTasa.TasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(laTasa);
        }

        private static double CalculeLaTasaNeta(InformacionTasaBruta laTasa)
        {
            //TODO Mas de una operacion
            return ((laTasa.ValorFacial - 
                laTasa.ValorTransadoNeto) / 
                (laTasa.ValorTransadoNeto * 
                (laTasa.DiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
