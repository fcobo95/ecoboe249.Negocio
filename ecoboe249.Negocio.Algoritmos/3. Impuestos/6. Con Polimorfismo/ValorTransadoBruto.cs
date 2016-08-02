using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class ValorTransadoBruto
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBruto(InformacionSobreImpuesto infoImpuesto)
        {
            elValorFacial = ObtengaElValorFacial(infoImpuesto);
            losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(infoImpuesto);
            InformacionTasaBruta infoTasaBruta = new InformacionTasaBruta();
            infoTasaBruta.ValorFacial = ObtengaElValorFacial(infoImpuesto);
            infoTasaBruta.ValorTransadoNeto = ObtengaElValorTransadoNeto(infoImpuesto);
            infoTasaBruta.TasaDeImpuesto = ObtengaLaTasaDeImpuesto(infoImpuesto);
            infoTasaBruta.DiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(infoImpuesto);
            laTasaBruta = CalculeLaTasaBruta(infoTasaBruta);
        }

        private double ObtengaLaTasaDeImpuesto(InformacionSobreImpuesto infoImpuesto)
        {
            return infoImpuesto.TasaDeImpuesto;
        }

        private double ObtengaElValorTransadoNeto(InformacionSobreImpuesto infoImpuesto)
        {
            return infoImpuesto.ValorTransadoNeto;
        }

        private double ObtengaElValorFacial(InformacionSobreImpuesto infoImpuesto)
        {
            return infoImpuesto.ValorFacial;
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
