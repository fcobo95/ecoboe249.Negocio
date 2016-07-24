using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class Fecha
    {
        private string elAñoComoTexto;
        private string elMesEsperadoComoTexto;
        private string elDiaEsperadoComoTexto;

        public Fecha(DateTime laFecha)
        {
            elAñoComoTexto = FormateeElAño(laFecha);
            elMesEsperadoComoTexto = FormateeElMes(laFecha);
            elDiaEsperadoComoTexto = FormateeElDia(laFecha);
        }

        private static string FormateeElAño(DateTime laFecha)
        {
            return new Año(laFecha).ComoTexto();
        }

        private static string FormateeElMes(DateTime laFecha)
        {
            return new Mes(laFecha).ComoTexto();
        }

        private static string FormateeElDia(DateTime laFecha)
        {
            return new Dia(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoComoTexto + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;
        }
    }
}
