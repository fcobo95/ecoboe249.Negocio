using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class CodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public CodigoDeReferencia(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            elRequerimiento = GenereElRequerimiento(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo);
            elDigitoVerificadorComoTexto = GenereElDigitoVerificador(elRequerimiento);
        }

        private static string GenereElRequerimiento(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            return new Requerimiento(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo).ComoTexto();
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
