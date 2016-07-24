using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElDiaATexto
    {
        private int elDia;

        public ElDiaATexto(DateTime laFecha)
        {
            elDia = ObtengaElDia(laFecha);
        }

        private static int ObtengaElDia(DateTime laFecha)
        {
            return laFecha.Day;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elDia);
        }
    }
}
