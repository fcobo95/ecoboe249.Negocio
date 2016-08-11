using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionValorTransadoConTratamiento : InformacionTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
            }
        }
    }
}
