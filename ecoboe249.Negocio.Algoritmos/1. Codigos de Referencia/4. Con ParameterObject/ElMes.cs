using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElMes
    {
        private string elMesComoTexto;

        public ElMes(InformacionDelCodigo elCodigo)
        {
            elMesComoTexto = ConviertaElMesATexto(elCodigo);
        }

        private static string ConviertaElMesATexto(InformacionDelCodigo elCodigo)
        {
            return new ElMesATexto(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
