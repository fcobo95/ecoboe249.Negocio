using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class Mes
    {
        private string elMesComoTexto;

        public Mes(DateTime laFecha)
        {
            elMesComoTexto = ConviertaElMesATexto(laFecha);
        }

        private static string ConviertaElMesATexto(DateTime laFecha)
        {
            return new MesATexto(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
