using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(InformacionTasaBruta laTasa)
        {
            laTasaDeImpuesto = ObtengaLaTasaDeImpuesto(laTasa);
            laTasaNeta = CalculeLaTasaNeta(laTasa);
        }

        private double ObtengaLaTasaDeImpuesto(InformacionTasaBruta laTasa)
        {
            return laTasa.TasaDeImpuesto;
        }

        private static double CalculeLaTasaNeta(InformacionTasaBruta laTasa)
        {
            return laTasa.TasaNeta();
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
