using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class DiaATexto
    {
        private int elDia;

        public DiaATexto(DateTime laFecha)
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
