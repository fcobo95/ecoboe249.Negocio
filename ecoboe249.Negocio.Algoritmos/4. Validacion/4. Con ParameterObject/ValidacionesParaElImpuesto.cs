using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.ValidacionesImpuesto
{
    public class ValidacionesParaElImpuesto
    {
        public static bool Validaciones(InformacionValidaciones lasValidaciones)
        {
            return new Validaciones(lasValidaciones).ValideQueSeaCierto();
        }
    }
}