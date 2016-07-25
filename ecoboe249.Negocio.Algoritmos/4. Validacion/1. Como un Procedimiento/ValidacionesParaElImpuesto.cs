using System;

namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.ValidacionesImpuesto
{
    public class ValidacionesParaElImpuesto
    {
        public static bool Validaciones(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            bool elValorFacialEsCorrecto;
            if (elValorFacial > 100000)
                elValorFacialEsCorrecto = true;
            else
                elValorFacialEsCorrecto = false;

            bool elValorTransadoNetoEsCorrecto;
            if (elValorTransadoNeto > 100000)
                elValorTransadoNetoEsCorrecto = true;
            else
                elValorTransadoNetoEsCorrecto = false;

            bool laTasaDeImpuestoEsCorrecta;
            if ((laTasaDeImpuesto < 1) & (laTasaDeImpuesto > 0))
                laTasaDeImpuestoEsCorrecta = true;
            else
                laTasaDeImpuestoEsCorrecta = false;

            bool laFechaActualEsMenorQueLaDeVencimientoEsValida;
            if (laFechaActual < laFechaDeVencimiento)
                laFechaActualEsMenorQueLaDeVencimientoEsValida = true;
            else
                laFechaActualEsMenorQueLaDeVencimientoEsValida = false;

            bool lasValidacionesSonVerdaderas;
            if (elValorFacialEsCorrecto & elValorTransadoNetoEsCorrecto
                & laTasaDeImpuestoEsCorrecta & laFechaActualEsMenorQueLaDeVencimientoEsValida)
                lasValidacionesSonVerdaderas = true;
            else
                lasValidacionesSonVerdaderas = false;

            return lasValidacionesSonVerdaderas;
        }
    }
}