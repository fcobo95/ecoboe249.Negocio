using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public static class CalculosDelCodigoDeReferencia
    {
        public static string CalculeElCodigoDeReferencia(InformacionDelCodigo elCodigo)
        {
            return new CodigoDeReferencia(elCodigo).ComoTexto();
        }
    }
}
