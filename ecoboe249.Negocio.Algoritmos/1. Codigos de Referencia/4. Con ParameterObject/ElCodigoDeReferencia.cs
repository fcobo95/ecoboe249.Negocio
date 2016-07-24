using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElCodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public ElCodigoDeReferencia(InformacionDelCodigo elCodigo)
        {
            elRequerimiento = GenereElRequerimiento(elCodigo);
            elDigitoVerificadorComoTexto = GenereElDigitoVerificador(elRequerimiento);
        }

        private static string GenereElRequerimiento(InformacionDelCodigo elCodigo)
        {
            return new ElRequerimiento(elCodigo).ComoTexto();
        }

        private static string GenereElDigitoVerificador(string elRequerimiento)
        {
            return new ElDigitoVerificador(elRequerimiento).ComoTexto();
        }

        public string ComoTexto()
        {
            return elRequerimiento + elDigitoVerificadorComoTexto;
        }
    }
}
