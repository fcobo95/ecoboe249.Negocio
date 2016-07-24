using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class LaFecha
    {
        private string elAñoComoTexto;
        private string elMesEsperadoComoTexto;
        private string elDiaEsperadoComoTexto;

        public LaFecha(InformacionDelCodigo elCodigo)
        {
            elAñoComoTexto = FormateeElAño(elCodigo);
            elMesEsperadoComoTexto = FormateeElMes(elCodigo);
            elDiaEsperadoComoTexto = FormateeElDia(elCodigo);
        }

        private static string FormateeElAño(InformacionDelCodigo elCodigo)
        {
            return new ElAño(elCodigo).ComoTexto();
        }

        private static string FormateeElMes(InformacionDelCodigo elCodigo)
        {
            return new ElMes(elCodigo).ComoTexto();
        }

        private static string FormateeElDia(InformacionDelCodigo elCodigo)
        {
            return new ElDia(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoComoTexto + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;
        }
    }
}
