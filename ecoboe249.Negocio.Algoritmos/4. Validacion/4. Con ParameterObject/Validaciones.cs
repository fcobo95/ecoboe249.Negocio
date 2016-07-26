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
            if (lasValidaciones.ValorFacial > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueElValorTransadoNeto(InformacionValidaciones lasValidaciones)
        {
            if (lasValidaciones.ValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaTasaDeImpuesto(InformacionValidaciones lasValidaciones)
        {
            if ((lasValidaciones.TasaDeImpuesto < 1) & (lasValidaciones.TasaDeImpuesto > 0))
                return true;
            else
                return false;
        }

        private static bool VerifiqueLaFecha(InformacionValidaciones lasValidaciones)
        {
            if (lasValidaciones.FechaActual < lasValidaciones.FechaDeVencimiento)
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
