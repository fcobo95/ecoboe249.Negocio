using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia
{
    public class Requerimiento
    {
        private string laFechaComoTexto;
        private string elNumeroDelClienteEsperado;
        private string elNumeroDelSistemaEsperado;
        private string elNumeroDelConsecutivoEsperado;

        public Requerimiento(InformacionDelCodigo elCodigo)
        {
            laFechaComoTexto = FormateeLaFecha(elCodigo);
            elNumeroDelClienteEsperado = FormateeElNumeroDelCliente(elCodigo);
            elNumeroDelSistemaEsperado = FormateeElNumeroDelSistema(elCodigo);
            elNumeroDelConsecutivoEsperado = FormateeElNumeroConsecutivo(elCodigo);
        }

        private static string FormateeLaFecha(InformacionDelCodigo elCodigo)
        {
            return new Fecha(elCodigo).ComoTexto();
        }

        private static string FormateeElNumeroDelCliente(InformacionDelCodigo elCodigo)
        {
            return elCodigo.ClienteFormateado;
        }

        private static string FormateeElNumeroDelSistema(InformacionDelCodigo elCodigo)
        {
            return elCodigo.SistemaFormateado;
        }

        private static string FormateeElNumeroConsecutivo(InformacionDelCodigo elCodigo)
        {
            return elCodigo.ConsecutivoFormateado;
        }

        public string ComoTexto()
        {
            return laFechaComoTexto + elNumeroDelClienteEsperado + elNumeroDelSistemaEsperado + elNumeroDelConsecutivoEsperado;
        }
    }
}
