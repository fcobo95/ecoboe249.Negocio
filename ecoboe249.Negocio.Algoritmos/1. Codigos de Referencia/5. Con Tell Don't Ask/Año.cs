using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
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
            //TODO Demeter
            return elCodigo.Fecha.Year;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elAño);
        }
    }
}
