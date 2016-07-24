using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public class ElValorTransadoBrutoConTratamientoFiscal
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ElValorTransadoBrutoConTratamientoFiscal(InformacionDelRendimiento elRendimiento)
        {
            InformacionTasaBruta laTasa;
            laTasa = new InformacionTasaBruta();
            this.elValorFacial = laTasa.ValorFacial;
            laTasa.ValorFacial = elRendimiento.ValorFacial;
            losDiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(elRendimiento);
            laTasaBruta = CalculeLaTasaBruta(laTasa);
        }

        private static double CalculeLosDiasAlVencimiento(InformacionDelRendimiento elRendimiento)
        {
            return new LosDiasAlVencimiento(elRendimiento).ComoNumero();
        }

        private static double CalculeLaTasaBruta(InformacionTasaBruta laTasa)
        {
            return new LaTasaBruta(laTasa).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));
        }
    }
}
