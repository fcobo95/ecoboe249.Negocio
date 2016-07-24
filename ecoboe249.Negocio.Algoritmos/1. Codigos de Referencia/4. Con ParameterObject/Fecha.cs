using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class Fecha
    {
        private string elAñoComoTexto;
        private string elMesEsperadoComoTexto;
        private string elDiaEsperadoComoTexto;

        public Fecha(InformacionDelCodigo elCodigo)
        {
            elAñoComoTexto = FormateeElAño(elCodigo);
            elMesEsperadoComoTexto = FormateeElMes(elCodigo);
            elDiaEsperadoComoTexto = FormateeElDia(elCodigo);
        }

        private static string FormateeElAño(InformacionDelCodigo elCodigo)
        {
            return new Año(elCodigo).ComoTexto();
        }

        private static string FormateeElMes(InformacionDelCodigo elCodigo)
        {
            return new Mes(elCodigo).ComoTexto();
        }

        private static string FormateeElDia(InformacionDelCodigo elCodigo)
        {
            return new Dia(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoComoTexto + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;
        }
    }
}
