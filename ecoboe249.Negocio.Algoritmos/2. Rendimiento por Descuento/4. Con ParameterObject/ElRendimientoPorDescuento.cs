using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.RendimientoPorDescuento
{
    public class ElRendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public ElRendimientoPorDescuento(InformacionDelRendimiento elRendimiento)
        {
            elValorFacial = elRendimiento.ValorFacial;
            elValorTransadoBruto = CalculeElValorTransadoBruto(elRendimiento);
        }

        private double CalculeElValorTransadoBruto(InformacionDelRendimiento elRendimiento)
        {
            if (elRendimiento.TieneTratamientoFiscal)
            {
                return ObtengaElValorTransadoBrutoConTratamientoFiscal(elRendimiento);
            }

            else
            {
                return ObtengaElValorTransadoBrutoSinTratamientoFiscal(elRendimiento);
            }
        }

        private double ObtengaElValorTransadoBrutoConTratamientoFiscal(InformacionDelRendimiento elRendimiento)
        {
            return new ElValorTransadoBrutoConTratamientoFiscal(elRendimiento).ComoNumero();
        }

        private double ObtengaElValorTransadoBrutoSinTratamientoFiscal(InformacionDelRendimiento elRendimiento)
        {
            return elRendimiento.ValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
