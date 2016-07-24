using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class Dia
    {
        private string elDiaComoTexto;

        public Dia(DateTime laFecha)
        {
            elDiaComoTexto = ConviertaElDiaATexto(laFecha);
        }

        private static string ConviertaElDiaATexto(DateTime laFecha)
        {
            return new DiaATexto(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
