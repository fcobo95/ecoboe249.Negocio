using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElMes
    {
        private string elMesComoTexto;

        public ElMes(DateTime laFecha)
        {
            elMesComoTexto = ConviertaElMesATexto(laFecha);
        }

        private static string ConviertaElMesATexto(DateTime laFecha)
        {
            return new ElMesATexto(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
