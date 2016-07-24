using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
{
    public class Dia
    {
        private string elDiaComoTexto;

        public Dia(InformacionDelCodigo elCodigo)
        {
            elDiaComoTexto = ConviertaElDiaATexto(elCodigo);
        }

        private static string ConviertaElDiaATexto(InformacionDelCodigo elCodigo)
        {
            return new DiaATexto(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
