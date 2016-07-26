using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.ValidacionesImpuesto
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
            //TODO Mas de una operacion
            if (lasValidaciones.ValorFacial > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueElValorTransadoNeto(InformacionValidaciones lasValidaciones)
        {
            //TODO Mas de una operacion
            if (lasValidaciones.ValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaTasaDeImpuesto(InformacionValidaciones lasValidaciones)
        {
            //TODO Mas de una operacion
            if ((lasValidaciones.TasaDeImpuesto < 1) & (lasValidaciones.TasaDeImpuesto > 0))
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaFecha(InformacionValidaciones lasValidaciones)
        {
            //TODO Mas de una operacion
            if (lasValidaciones.FechaActual < lasValidaciones.FechaDeVencimiento)
                return true;
            else
                return false;
        }

        public bool ValideQueSeaCierto()
        {
            //TODO Mas de una operacion (No estoy seguro del todo, preguntar)
            if (elValorFacialEsCorrecto & elValorTransadoNetoEsCorrecto
                & laTasaDeImpuestoEsCorrecta & laFechaActualEsMenorQueLaDeVencimientoEsValida)
                return true;
            else
                return false;
        }
    }
}
