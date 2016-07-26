using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.ValidacionesImpuesto
{
    public class ValidacionesParaElImpuesto
    {
        public static bool Validaciones(InformacionValidaciones lasValidaciones)
        {
            return new Validaciones(lasValidaciones).ValideQueSeaCierto();
        }
    }
}