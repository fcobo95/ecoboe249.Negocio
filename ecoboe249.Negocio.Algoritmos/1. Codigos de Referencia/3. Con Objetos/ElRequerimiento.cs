using System;

namespace ecoboe249.Negocio.Algoritmos.ConObjetos.CodigosDeReferencia
{
    public class ElRequerimiento
    {
        private string laFechaComoTexto;
        private string elNumeroDelClienteEsperado;
        private string elNumeroDelSistemaEsperado;
        private string elNumeroDelConsecutivoEsperado;

        public ElRequerimiento(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            laFechaComoTexto = FormateeLaFecha(laFecha);
            elNumeroDelClienteEsperado = FormateeElNumeroDelCliente(elNumeroDelCliente);
            elNumeroDelSistemaEsperado = FormateeElNumeroDelSistema(elNumeroDelSistema);
            elNumeroDelConsecutivoEsperado = FormateeElNumeroConsecutivo(elNumeroDelConsecutivo);
        }

        private static string FormateeLaFecha(DateTime laFecha)
        {
            return new LaFecha(laFecha).ComoTexto();
        }

        private static string FormateeElNumeroDelCliente(string elNumeroDelCliente)
        {
            return elNumeroDelCliente.PadLeft(3, '0');
        }

        private static string FormateeElNumeroDelSistema(string elNumeroDelSistema)
        {
            return elNumeroDelSistema.PadLeft(2, '0');
        }

        private static string FormateeElNumeroConsecutivo(string elNumeroDelConsecutivo)
        {
            return elNumeroDelConsecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return laFechaComoTexto + elNumeroDelClienteEsperado + elNumeroDelSistemaEsperado + elNumeroDelConsecutivoEsperado;
        }
    }
}
