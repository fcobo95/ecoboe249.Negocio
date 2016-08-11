using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBrutoConTratamientoFiscal(InformacionTasaBruta elRendimiento)
        {
            losDiasAlVencimientoComoNumero = elRendimiento.DiasAlVencimientoComoNumero;
            laTasaBruta = CalculeLaTasaBruta(elRendimiento);
            elValorFacial = ObtengaElValorFacialDelRendimiento(elRendimiento);
        }

        private double ObtengaElValorFacialDelRendimiento(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorFacial;
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
