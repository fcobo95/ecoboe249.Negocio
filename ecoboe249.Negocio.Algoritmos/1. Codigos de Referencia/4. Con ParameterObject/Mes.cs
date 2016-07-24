using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class Mes
    {
        private string elMesComoTexto;

        public Mes(InformacionDelCodigo elCodigo)
        {
            elMesComoTexto = ConviertaElMesATexto(elCodigo);
        }

        private static string ConviertaElMesATexto(InformacionDelCodigo elCodigo)
        {
            return new MesATexto(elCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
