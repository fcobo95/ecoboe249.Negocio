using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double elValorFacial;

        public ValorTransadoBrutoConTratamientoFiscal(InformacionDelRendimiento elRendimiento)
        {
            elValorFacial = ObtengaElValorFacialDelRendimiento(elRendimiento);
            losDiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(elRendimiento);
            InformacionTasaBruta laTasa = new InformacionTasaBruta();
            laTasa.ValorFacial = ObtengaElValorFacialDelRendimiento(elRendimiento);
            laTasa.ValorTransadoNeto = ObtengaElValorTransadoNetoDelRendimiento(elRendimiento);
            laTasa.TasaDeImpuesto = ObtengaLaTasaDeImpuestoDelRendimiento(elRendimiento);
            laTasa.DiasAlVencimientoComoNumero = CalculeLosDiasAlVencimiento(elRendimiento);
            laTasaBruta = CalculeLaTasaBruta(laTasa);
        }

        private double ObtengaLaTasaDeImpuestoDelRendimiento(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.TasaDeImpuesto;
        }

        private double ObtengaElValorTransadoNetoDelRendimiento(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorTransadoNeto;
        }

        private double ObtengaElValorFacialDelRendimiento(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorFacial;
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
