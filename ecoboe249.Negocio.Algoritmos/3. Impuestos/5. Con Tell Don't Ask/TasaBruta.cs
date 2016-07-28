using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto
{
    public class TasaBruta
    {
        private double laTasaNeta;
        private double laTasaDeImpuesto;

        public TasaBruta(InformacionTasaBruta infoTasaBruta)
        {
            laTasaNeta = ObtengaLaTasaNeta(infoTasaBruta);
            laTasaDeImpuesto = ObtengaLaTasaDeImpuesto(infoTasaBruta);
        }

        private double ObtengaLaTasaDeImpuesto(InformacionTasaBruta infoTasaBruta)
        {
            return infoTasaBruta.TasaDeImpuesto;
        }

        private static double ObtengaLaTasaNeta(InformacionTasaBruta infoTasaBruta)
        {
            return infoTasaBruta.TasaNeta;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
