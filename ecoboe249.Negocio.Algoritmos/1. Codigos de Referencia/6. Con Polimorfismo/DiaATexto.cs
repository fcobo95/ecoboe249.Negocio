using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia
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
            return elCodigo.Dia;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elDia);
        }
    }
}
