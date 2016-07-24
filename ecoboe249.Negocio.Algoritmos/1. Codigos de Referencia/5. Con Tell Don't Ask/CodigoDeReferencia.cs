using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
{
    public class CodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public CodigoDeReferencia(InformacionDelCodigo elCodigo)
        {
            elRequerimiento = GenereElRequerimiento(elCodigo);
            elDigitoVerificadorComoTexto = GenereElDigitoVerificador(elRequerimiento);
        }

        private static string GenereElRequerimiento(InformacionDelCodigo elCodigo)
        {
            return new Requerimiento(elCodigo).ComoTexto();
        }

        private static string GenereElDigitoVerificador(string elRequerimiento)
        {
            return new DigitoVerificador(elRequerimiento).ComoTexto();
        }

        public string ComoTexto()
        {
            return elRequerimiento + elDigitoVerificadorComoTexto;
        }
    }
}
