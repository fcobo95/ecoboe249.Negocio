using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElMesATexto
    {
        private int elMes;

        public ElMesATexto(DateTime laFecha)
        {
            elMes = ObtengaElMes(laFecha);
        }

        private static int ObtengaElMes(DateTime laFecha)
        {
            return laFecha.Month;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elMes);
        }
    }
}
