using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;

        public Impuesto(InformacionTasaBruta infoImpuesto)
        {
            elValorTransadoBruto = GenerelElValorTransadoBruto(infoImpuesto);
            elValorTransadoNeto = infoImpuesto.ValorTransadoNeto;
        }

        private static double GenerelElValorTransadoBruto(InformacionTasaBruta infoImpuesto)
        {
            return new ValorTransadoBruto(infoImpuesto).ComoNumero();
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
