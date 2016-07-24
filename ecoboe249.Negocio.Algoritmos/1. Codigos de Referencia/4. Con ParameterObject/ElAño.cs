using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElAño
    {
        private int elAño;

        public ElAño(InformacionDelCodigo elCodigo)
        {
            elAño = ObtengaElAño(elCodigo);
        }

        private static int ObtengaElAño(InformacionDelCodigo elCodigo)
        {
            return elCodigo.Fecha.Year; ;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elAño);
        }
    }
}
