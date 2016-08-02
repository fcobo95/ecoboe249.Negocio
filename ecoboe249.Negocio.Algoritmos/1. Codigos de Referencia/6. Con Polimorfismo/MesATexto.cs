using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia
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
            return elCodigo.Mes;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elMes);
        }
    }
}
