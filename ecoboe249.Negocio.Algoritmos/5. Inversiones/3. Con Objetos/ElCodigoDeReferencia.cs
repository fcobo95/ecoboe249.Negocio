using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElCodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public ElCodigoDeReferencia(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            elRequerimiento = GenereElRequerimiento(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo);
            elDigitoVerificadorComoTexto = GenereElDigitoVerificador(elRequerimiento);
        }

        private static string GenereElRequerimiento(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            return new ElRequerimiento(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo).ComoTexto();
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
