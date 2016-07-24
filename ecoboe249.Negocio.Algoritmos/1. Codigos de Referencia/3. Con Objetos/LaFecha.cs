using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class LaFecha
    {
        private string elAñoComoTexto;
        private string elMesEsperadoComoTexto;
        private string elDiaEsperadoComoTexto;

        public LaFecha(DateTime laFecha)
        {
            elAñoComoTexto = FormateeElAño(laFecha);
            elMesEsperadoComoTexto = FormateeElMes(laFecha);
            elDiaEsperadoComoTexto = FormateeElDia(laFecha);
        }

        private static string FormateeElAño(DateTime laFecha)
        {
            return new ElAño(laFecha).ComoTexto();
        }

        private static string FormateeElMes(DateTime laFecha)
        {
            return new ElMes(laFecha).ComoTexto();
        }

        private static string FormateeElDia(DateTime laFecha)
        {
            return new ElDia(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoComoTexto + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;
        }
    }
}
