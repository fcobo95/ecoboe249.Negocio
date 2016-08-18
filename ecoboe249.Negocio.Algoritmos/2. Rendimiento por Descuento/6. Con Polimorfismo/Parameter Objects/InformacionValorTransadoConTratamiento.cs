using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuestos;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos
{
    public class InformacionValorTransadoConTratamiento : InformacionTasaBruta
    {
        public override double Impuesto
        {
            get
            {
                return new ImpuestoConTratamientoFiscal(this).ComoNumero();
            }
        }

        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
            }
        }
    }
}
