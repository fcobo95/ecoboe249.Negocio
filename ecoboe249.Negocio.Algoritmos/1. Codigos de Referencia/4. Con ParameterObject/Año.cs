using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class Año
    {
        private int elAño;

        public Año(InformacionDelCodigo elCodigo)
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
