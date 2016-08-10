using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(InformacionDelRendimiento elRendimiento)
        {
            elValorFacial = ObtengaElValorFacial(elRendimiento);
            elValorTransadoBruto = CalculeElValorTransadoBruto(elRendimiento);
        }

        private double ObtengaElValorFacial(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorFacial;
        }

        private double CalculeElValorTransadoBruto(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorTransadoBruto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
