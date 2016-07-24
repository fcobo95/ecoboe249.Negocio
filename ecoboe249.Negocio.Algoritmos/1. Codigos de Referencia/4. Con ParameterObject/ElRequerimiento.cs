using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.CodigosDeReferencia
{
    public class ElRequerimiento
    {
        private string laFechaComoTexto;
        private string elNumeroDelClienteEsperado;
        private string elNumeroDelSistemaEsperado;
        private string elNumeroDelConsecutivoEsperado;

        public ElRequerimiento(InformacionDelCodigo elCodigo)
        {
            laFechaComoTexto = FormateeLaFecha(elCodigo);
            elNumeroDelClienteEsperado = FormateeElNumeroDelCliente(elCodigo);
            elNumeroDelSistemaEsperado = FormateeElNumeroDelSistema(elCodigo);
            elNumeroDelConsecutivoEsperado = FormateeElNumeroConsecutivo(elCodigo);
        }

        private static string FormateeLaFecha(InformacionDelCodigo elCodigo)
        {
            return new LaFecha(elCodigo).ComoTexto();
        }

        private static string FormateeElNumeroDelCliente(InformacionDelCodigo elCodigo)
        {
            return elCodigo.NumeroDelCliente.PadLeft(3, '0');
        }

        private static string FormateeElNumeroDelSistema(InformacionDelCodigo elCodigo)
        {
            return elCodigo.NumeroDelSistema.PadLeft(2, '0');
        }

        private static string FormateeElNumeroConsecutivo(InformacionDelCodigo elCodigo)
        {
            return elCodigo.NumeroDelConsecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return laFechaComoTexto + elNumeroDelClienteEsperado + elNumeroDelSistemaEsperado + elNumeroDelConsecutivoEsperado;
        }
    }
}
