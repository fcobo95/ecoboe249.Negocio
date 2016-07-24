using System;

namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.CodigosDeReferencia
{
    public static class CalculosDelCodigoDeReferencia
    {
        public static string CalculeElCodigoDeReferencia(DateTime laFecha, string elNumeroDelCliente, string elNumeroDelSistema, string elNumeroDelConsecutivo)
        {
            int elAñoEsperado = laFecha.Year; ;
            string elAñoEsperadoComoTexto = Convert.ToString(elAñoEsperado);

            int elMes = laFecha.Month;
            string elMesComoTexto = Convert.ToString(elMes);
            string elMesEsperadoComoTexto = elMesComoTexto.PadLeft(2, '0');

            int elDia = laFecha.Day;
            string elDiaComoTexto = Convert.ToString(elDia);
            string elDiaEsperadoComoTexto = elDiaComoTexto.PadLeft(2, '0');

            string laFechaComoTexto = elAñoEsperado + elMesEsperadoComoTexto + elDiaEsperadoComoTexto;

            string elNumeroDelClienteEsperado = elNumeroDelCliente.PadLeft(3, '0');

            string elNumeroDelSistemaEsperado = elNumeroDelSistema.PadLeft(2, '0');

            string elNumeroDelConsecutivoEsperado = elNumeroDelConsecutivo.PadLeft(12, '0');

            string elRequerimiento = laFechaComoTexto + elNumeroDelClienteEsperado + elNumeroDelSistemaEsperado + elNumeroDelConsecutivoEsperado;

            int elDigitoVerificadorComoNumero = CalculeElDigitoVerificador(elRequerimiento);

            string elDigitoVerificadorComoTexto = elDigitoVerificadorComoNumero.ToString();

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
