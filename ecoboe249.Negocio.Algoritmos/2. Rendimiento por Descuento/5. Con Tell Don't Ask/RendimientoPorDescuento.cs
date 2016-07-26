using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(InformacionDelRendimiento elRendimiento)
        {
            //TODO Arreglar detalles
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
            return new ValorTransadoBrutoConTratamientoFiscal(elRendimiento).ComoNumero();
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
