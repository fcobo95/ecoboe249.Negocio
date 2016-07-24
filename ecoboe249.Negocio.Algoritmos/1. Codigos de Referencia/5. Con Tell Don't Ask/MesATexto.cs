using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
{
    public class MesATexto
    {
        private int elMes;

        public MesATexto(InformacionDelCodigo elCodigo)
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
