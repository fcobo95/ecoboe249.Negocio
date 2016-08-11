using System;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class InformacionImpuestoSinTratamientoFiscal : InformacionTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return 0;
            }
        }
    }
}
