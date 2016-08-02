namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.ValidacionesImpuesto
{
    public class Validaciones
    {
        private bool elValorFacialEsCorrecto;
        private bool elValorTransadoNetoEsCorrecto;
        private bool laTasaDeImpuestoEsCorrecta;
        private bool laFechaActualEsMenorQueLaDeVencimientoEsValida;

        public Validaciones(InformacionValidaciones lasValidaciones)
        {
            elValorFacialEsCorrecto = lasValidaciones.ValorFacialEsValido();
            elValorTransadoNetoEsCorrecto = lasValidaciones.ValorTransadoNetoEsValido();
            laTasaDeImpuestoEsCorrecta = lasValidaciones.TasaDeImpuestoEsValido();
            laFechaActualEsMenorQueLaDeVencimientoEsValida = lasValidaciones.FechaEsValida();
        }

        public bool ValideQueSeaCierto()
        {
            if (elValorFacialEsCorrecto & elValorTransadoNetoEsCorrecto
                & laTasaDeImpuestoEsCorrecta & laFechaActualEsMenorQueLaDeVencimientoEsValida)
                return true;
            else
                return false;
        }
    }
}
