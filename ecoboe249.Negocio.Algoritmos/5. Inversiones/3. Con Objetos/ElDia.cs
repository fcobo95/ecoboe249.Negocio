using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElDia
    {
        private string elDiaComoTexto;

        public ElDia(DateTime laFecha)
        {
            elDiaComoTexto = ConviertaElDiaATexto(laFecha);
        }

        private static string ConviertaElDiaATexto(DateTime laFecha)
        {
            return new ElDiaATexto(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
