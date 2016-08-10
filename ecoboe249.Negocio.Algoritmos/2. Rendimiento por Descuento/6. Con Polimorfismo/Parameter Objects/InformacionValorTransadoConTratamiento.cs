namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionValorTransadoConTratamiento : InformacionTasaBruta
    {
        private double ValorTransadoBrutoConTratamientoFiscal()
        {
            return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
        }
    }
}
