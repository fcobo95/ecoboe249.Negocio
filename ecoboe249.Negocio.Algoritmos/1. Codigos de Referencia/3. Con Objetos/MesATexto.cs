using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class MesATexto
    {
        private int elMes;

        public MesATexto(DateTime laFecha)
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
