using System;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class InformacionImpuestoConTratamientoFiscal : InformacionTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return new ImpuestoConTratamientoFiscal(this).ComoNumero();
            }
        }
    }
}

