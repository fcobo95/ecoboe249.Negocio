namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento
{
    public class InformacionValorTransadoSinTratamiento : InformacionTasaBruta
    {
        private double ValorTransadoBrutoSinTratamientoFiscal()
        {
            return ValorTransadoNeto;
        }
    }
}
