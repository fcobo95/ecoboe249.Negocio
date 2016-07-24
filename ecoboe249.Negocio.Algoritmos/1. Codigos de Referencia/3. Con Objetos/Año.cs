using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class Año
    {
        private int elAño;

        public Año(DateTime laFecha)
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
