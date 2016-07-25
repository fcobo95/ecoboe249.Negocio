using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBrutoConTratamientoFiscal(InformacionDelRendimiento elRendimiento)
        {
            //TODO Detalles
            elValorFacial = elRendimiento.ValorFacial;
            losDiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(elRendimiento);
            InformacionTasaBruta laTasa = new InformacionTasaBruta();
            laTasa.ValorFacial = elRendimiento.ValorFacial;
            laTasa.ValorTransadoNeto = elRendimiento.ValorTransadoNeto;
            laTasa.TasaDeImpuesto = elRendimiento.TasaDeImpuesto;
            laTasa.DiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(elRendimiento);
            laTasaBruta = CalculeLaTasaBruta(laTasa);
        }

        private static double CalculeLosDiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            return new DiasAlVencimiento(elRendimiento).ComoNumero();
        }

        private static double CalculeLaTasaBruta(InformacionTasaBruta laTasa)
        {
            return new TasaBruta(laTasa).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }
    }
}
