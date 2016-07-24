using System;

namespace ecoboe249.Negocio.Algoritmos.ConFunciones.CodigosDeReferencia
{
    public static class CalculosDelCodigoDeReferencia
    {
        public static string CalculeElCodigoDeReferencia(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            string elRequerimiento = GenereElRequerimiento(laFecha, elNumeroDelCliente, elNumeroDelSistema, elNumeroDelConsecutivo);
            string elDigitoVerificadorComoTexto = GenereElDigitoVerificador(elRequerimiento);

            return GenereElCodigoDeReferencia(elRequerimiento, elDigitoVerificadorComoTexto);
        }

        private static string GenereElRequerimiento(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            string laFechaComoTexto = FormateeLaFecha(laFecha);
            string elNumeroDelClienteEsperado = FormateeElNumeroDelCliente(elNumeroDelCliente);
            string elNumeroDelSistemaEsperado = FormateeElNumeroDelSistema(elNumeroDelSistema);
            string elNumeroDelConsecutivoEsperado = FormateeElNumeroConsecutivo(elNumeroDelConsecutivo);

            return CalculeElRequerimiento(laFechaComoTexto, elNumeroDelClienteEsperado, elNumeroDelSistemaEsperado, elNumeroDelConsecutivoEsperado);
        }

        private static string GenereElDigitoVerificador(string elRequerimiento)
        {
            int elDigitoVerificadorComoNumero = CalculeElDigitoVerificador(elRequerimiento);

            return FormateeElDigitoVerificadorComoTexto(elDigitoVerificadorComoNumero);
        }

        private static string FormateeElDigitoVerificadorComoTexto(int elDigitoVerificadorComoNumero)
        {
            return elDigitoVerificadorComoNumero.ToString();
        }

        private static string FormateeLaFecha(DateTime laFecha)
        {
            string elAñoComoTexto = FormateeElAño(laFecha);
            string elMesEsperadoComoTexto = FormateeElMes(laFecha);
            string elDiaEsperadoComoTexto = FormateeElDia(laFecha);

            return CalculeLaFecha(elAñoComoTexto, elMesEsperadoComoTexto, elDiaEsperadoComoTexto);
        }

        private static string FormateeElAño(DateTime laFecha)
        {
            int elAño = ObtengaElAño(laFecha);

            return FormateeElAñoComoTexto(elAño);
        }

        private static int ObtengaElAño(DateTime laFecha)
        {
            return laFecha.Year; ;
        }

        private static string FormateeElAñoComoTexto(int elAño)
        {
            return Convert.ToString(elAño);
        }

        private static string FormateeElMes(DateTime laFecha)
        {
            string elMesComoTexto = ConviertaElMesATexto(laFecha);

            return FormateeElMesConCeros(elMesComoTexto);
        }

        private static string ConviertaElMesATexto(DateTime laFecha)
        {
            int elMes = ObtengaElMes(laFecha);

            return FormateeElMesComoTexto(elMes);
        }

        private static int ObtengaElMes(DateTime laFecha)
        {
            return laFecha.Month;
        }

        private static string FormateeElMesComoTexto(int elMes)
        {
            return Convert.ToString(elMes);
        }

        private static string FormateeElMesConCeros(string elMesComoTexto)
        {
            return elMesComoTexto.PadLeft(2, '0');
        }

        private static string FormateeElDia(DateTime laFecha)
        {
            string elDiaComoTexto = ConviertaElDiaATexto(laFecha);

            return FormateeElDiaConCeros(elDiaComoTexto);
        }

        private static string ConviertaElDiaATexto(DateTime laFecha)
        {
            int elDia = ObtengaElDia(laFecha);

            return FormateeElDiaComoTexto(elDia);
        }

        private static int ObtengaElDia(DateTime laFecha)
        {
            return laFecha.Day;
        }

        private static string FormateeElDiaComoTexto(int elDia)
        {
            return Convert.ToString(elDia);
        }

        private static string FormateeElDiaConCeros(string elDiaComoTexto)
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }

        private static string CalculeLaFecha(string elAñoComoTexto, string elMesEsperadoComoTexto, string elDiaEsperadoComoTexto)
        {
            return elAñoComoTexto + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;
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

        private static string CalculeElRequerimiento(string laFechaComoTexto, string elNumeroDelClienteEsperado, string elNumeroDelSistemaEsperado, string elNumeroDelConsecutivoEsperado)
        {
            return laFechaComoTexto + elNumeroDelClienteEsperado + elNumeroDelSistemaEsperado + elNumeroDelConsecutivoEsperado;
        }

        private static string GenereElCodigoDeReferencia(string elRequerimiento, string elDigitoVerificadorComoTexto)
        {
            return elRequerimiento + elDigitoVerificadorComoTexto;
        }

        public static int CalculeElDigitoVerificador(string elRequerimiento)
        {
            const string laHileraDePesos = "1234567891234567891234567";

            int elInicioDelPeso = 0;
            elInicioDelPeso = laHileraDePesos.Length - elRequerimiento.Length;

            int laSumaDePesos = 0;
            short laPosicionActual = 0;
            for (laPosicionActual = 0; laPosicionActual <= elRequerimiento.Length - 1; laPosicionActual++)
            {
                int elPesoActual = short.Parse(elRequerimiento.Substring(laPosicionActual, 1)) * short.Parse(laHileraDePesos.Substring(elInicioDelPeso + laPosicionActual, 1));
                laSumaDePesos = laSumaDePesos + elPesoActual;
            }

            int elResiduo = laSumaDePesos % 11;

            int elDigito;
            if (elResiduo == 10)
                elDigito = 1;
            else
                elDigito = elResiduo;

            return elDigito;
        }

    }
}
