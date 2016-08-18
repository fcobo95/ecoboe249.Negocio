using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos
{
    public class RendimientoPorDescuentoReal
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuentoReal(InformacionTasaBruta elRendimiento)
        {
            elValorFacial = ObtengaElValorFacial(elRendimiento);
            elValorTransadoBruto = CalculeElValorTransadoBruto(elRendimiento);
        }

        private double ObtengaElValorFacial(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorFacial;
        }

        private double CalculeElValorTransadoBruto(InformacionTasaBruta elRendimiento)
        {
            return elRendimiento.ValorTransadoBruto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
