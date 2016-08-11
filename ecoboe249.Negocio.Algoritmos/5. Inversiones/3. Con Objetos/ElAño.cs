using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElAño
    {
        private int elAño;

        public ElAño(DateTime laFecha)
        {
            elAño = ObtengaElAño(laFecha);
        }

        private static int ObtengaElAño(DateTime laFecha)
        {
            return laFecha.Year; ;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elAño);
        }
    }
}
