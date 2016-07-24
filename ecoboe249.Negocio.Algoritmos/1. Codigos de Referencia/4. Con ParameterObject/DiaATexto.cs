using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class DiaATexto
    {
        private int elDia;

        public DiaATexto(InformacionDelCodigo elCodigo)
        {
            elDia = ObtengaElDia(elCodigo);
        }

        private static int ObtengaElDia(InformacionDelCodigo elCodigo)
        {
            //TODO
            return elCodigo.Fecha.Day;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elDia);
        }
    }
}
