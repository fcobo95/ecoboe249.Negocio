using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.ValidacionesImpuesto
{
    public class ValidacionesParaElImpuesto
    {
        public static bool Validaciones(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new Validaciones(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ValideQueSeaCierto();
        }
    }
}