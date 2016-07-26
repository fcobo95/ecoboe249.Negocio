using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.Impuesto
{
    public class ValorTransadoBruto
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBruto(InformacionSobreImpuesto infoImpuesto)
        {
            //TODO DEFINITIVAMENTE Arreglar Detalles
            elValorFacial = infoImpuesto.ValorFacial;
            losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(infoImpuesto);
            InformacionTasaBruta infoTasaBruta = new InformacionTasaBruta();
            infoTasaBruta.ValorFacial = infoImpuesto.ValorFacial;
            infoTasaBruta.ValorTransadoNeto = infoImpuesto.ValorTransadoNeto;
            infoTasaBruta.TasaDeImpuesto = infoImpuesto.TasaDeImpuesto;
            infoTasaBruta.DiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(infoImpuesto);
            laTasaBruta = CalculeLaTasaBruta(infoTasaBruta);
        }

        private static double GenereLosDiasAlVencimiento(InformacionSobreImpuesto infoImpuesto)
        {
            return new DiasAlVencimiento(infoImpuesto).ComoNumero();
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
