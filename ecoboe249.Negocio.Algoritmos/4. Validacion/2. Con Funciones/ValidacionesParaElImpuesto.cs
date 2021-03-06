﻿using System;

namespace ecoboe249.Negocio.Algoritmos.ConFunciones.ValidacionesImpuesto
{
    public class ValidacionesParaElImpuesto
    {
        public static bool Validaciones(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            bool elValorFacialEsCorrecto = VerifiqueElValorFacial(elValorFacial);
            bool elValorTransadoNetoEsCorrecto = VerifiqueElValorTransadoNeto(elValorTransadoNeto);
            bool laTasaDeImpuestoEsCorrecta = VerifiqueLaTasaDeImpuesto(laTasaDeImpuesto);
            bool laFechaActualEsMenorQueLaDeVencimientoEsValida = VerifiqueLaFecha(laFechaDeVencimiento, laFechaActual);

            return VerifiqueQueTodasLasValidacionesSeanVerdaderas(elValorFacialEsCorrecto, elValorTransadoNetoEsCorrecto, laTasaDeImpuestoEsCorrecta, laFechaActualEsMenorQueLaDeVencimientoEsValida);
        }

        private static bool VerifiqueElValorFacial(double elValorFacial)
        {
            if (elValorFacial > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueElValorTransadoNeto(double elValorTransadoNeto)
        {
            if (elValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaTasaDeImpuesto(double laTasaDeImpuesto)
        {
            if ((laTasaDeImpuesto < 1) & (laTasaDeImpuesto > 0))
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaFecha(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            if (laFechaActual < laFechaDeVencimiento)
                return true;
            else
                return false;
        }

        private static bool VerifiqueQueTodasLasValidacionesSeanVerdaderas(bool elValorFacialEsCorrecto, bool elValorTransadoNetoEsCorrecto, bool laTasaDeImpuestoEsCorrecta, bool laFechaActualEsMenorQueLaDeVencimientoEsValida)
        {
            if (elValorFacialEsCorrecto & elValorTransadoNetoEsCorrecto
                & laTasaDeImpuestoEsCorrecta & laFechaActualEsMenorQueLaDeVencimientoEsValida)
                return true;
            else
                return false;
        }
    }
}