using System;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuento;


namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.GeneracionDeInversiones
{
    public static class GeneradorDeInversiones
    {
        public static NuevaInversion GenereUnaNuevaInversion(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaActual, DateTime laFechaDeVencimiento, bool TieneTratamientoFiscal,
            string elConsecutivoParaElCodigoDeReferencia)
        {
            NuevaInversion laNuevaInversion = new NuevaInversion();

            InformacionDelCodigo laInformacion = new InformacionDelCodigo();
            laInformacion.NumeroDelCliente = "22";
            laInformacion.NumeroDelSistema = "5";
            laInformacion.NumeroDelConsecutivo = elConsecutivoParaElCodigoDeReferencia;
            laInformacion.Fecha = laFechaActual;
            laNuevaInversion.CodigoDeReferencia = new CodigoDeReferencia(laInformacion).ComoTexto();

            
            laNuevaInversion.TasaNeta = 0;
            laNuevaInversion.TasaBruta = 0;
            laNuevaInversion.ValorTransadoBruto = 0;
            laNuevaInversion.ImpuestoPagado = 0;
            laNuevaInversion.RendimientoPorDescuento = 0;
            laNuevaInversion.FechaDeValor = laFechaActual;
            laNuevaInversion.FechaDeVencimiento = laFechaDeVencimiento;

            return laNuevaInversion;
        }
    }
}
