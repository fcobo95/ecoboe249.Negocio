using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.ValidacionesImpuesto
{
    public class Validaciones
    {
        private bool elValorFacialEsCorrecto;
        private bool elValorTransadoNetoEsCorrecto;
        private bool laTasaDeImpuestoEsCorrecta;
        private bool laFechaActualEsMenorQueLaDeVencimientoEsValida;

        public Validaciones(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elValorFacialEsCorrecto = VerifiqueElValorFacial(elValorFacial);
            elValorTransadoNetoEsCorrecto = VerifiqueElValorTransadoNeto(elValorTransadoNeto);
            laTasaDeImpuestoEsCorrecta = VerifiqueLaTasaDeImpuesto(laTasaDeImpuesto);
            laFechaActualEsMenorQueLaDeVencimientoEsValida = VerifiqueLaFecha(laFechaDeVencimiento, laFechaActual);
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
