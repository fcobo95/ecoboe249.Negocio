﻿namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.ValidacionesImpuesto
{
    public class Validaciones
    {
        private bool elValorFacialEsCorrecto;
        private bool elValorTransadoNetoEsCorrecto;
        private bool laTasaDeImpuestoEsCorrecta;
        private bool laFechaActualEsMenorQueLaDeVencimientoEsValida;

        public Validaciones(InformacionValidaciones lasValidaciones)
        {
            elValorFacialEsCorrecto = VerifiqueElValorFacial(lasValidaciones);
            elValorTransadoNetoEsCorrecto = VerifiqueElValorTransadoNeto(lasValidaciones);
            laTasaDeImpuestoEsCorrecta = VerifiqueLaTasaDeImpuesto(lasValidaciones);
            laFechaActualEsMenorQueLaDeVencimientoEsValida = VerifiqueLaFecha(lasValidaciones);
        }

        private static bool VerifiqueElValorFacial(InformacionValidaciones lasValidaciones)
        {
            return lasValidaciones.ValorFacialEsValido();
        }

        private static bool VerifiqueElValorTransadoNeto(InformacionValidaciones lasValidaciones)
        {
            return lasValidaciones.ValorTransadoNetoEsValido();
        }

        private static bool VerifiqueLaTasaDeImpuesto(InformacionValidaciones lasValidaciones)
        {
            return lasValidaciones.TasaDeImpuestoEsValido();
        }

        private static bool VerifiqueLaFecha(InformacionValidaciones lasValidaciones)
        {
            return lasValidaciones.FechaEsValida();
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
