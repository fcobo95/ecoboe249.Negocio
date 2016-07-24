using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElMesATexto
    {
        private int elMes;

        public ElMesATexto(InformacionDelCodigo elCodigo)
        {
            elMes = ObtengaElMes(elCodigo);
        }

        private static int ObtengaElMes(InformacionDelCodigo elCodigo)
        {
            //TODO
            return elCodigo.Fecha.Month;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elMes);
        }
    }
}
