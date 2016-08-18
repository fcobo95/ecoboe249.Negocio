using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos
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

        public override double Impuesto
        {
            get
            {
                return 0;
            }
        }
    }
}
