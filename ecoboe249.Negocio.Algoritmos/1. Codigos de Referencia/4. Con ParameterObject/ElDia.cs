using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElDia
    {
        private string elDiaComoTexto;

        public ElDia(InformacionDelCodigo elCodigo)
        {
            elDiaComoTexto = ConviertaElDiaATexto(elCodigo);
        }

        private static string ConviertaElDiaATexto(InformacionDelCodigo elCodigo)
        {
            return new ElDiaATexto(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
