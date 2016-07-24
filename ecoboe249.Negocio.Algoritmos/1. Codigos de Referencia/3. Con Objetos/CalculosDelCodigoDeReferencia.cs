using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public static class CalculosDelCodigoDeReferencia
    {
        public static string CalculeElCodigoDeReferencia(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            return new CodigoDeReferencia(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo).ComoTexto();
        }
    }
}
