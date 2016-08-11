using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionValorTransadoSinTratamiento : InformacionTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return ValorTransadoNeto;
            }
        }
    }
}
