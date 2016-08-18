using System;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos;
using ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuestos;


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

            if (TieneTratamientoFiscal)
            {
                InformacionValorTransadoConTratamiento laInformacionDeRendimiento = new InformacionValorTransadoConTratamiento();
                laInformacionDeRendimiento.ValorFacial = elValorFacial;
                laInformacionDeRendimiento.ValorTransadoNeto = elValorTransadoNeto;
                laInformacionDeRendimiento.TasaDeImpuesto = laTasaDeImpuesto;
                laNuevaInversion.TasaNeta = laInformacionDeRendimiento.TasaNeta;
                laNuevaInversion.TasaBruta = new TasaBruta(laInformacionDeRendimiento).ComoNumero();
                laNuevaInversion.ValorTransadoBruto = laInformacionDeRendimiento.ValorTransadoBruto;
                laNuevaInversion.ImpuestoPagado = laInformacionDeRendimiento.Impuesto;
                laNuevaInversion.RendimientoPorDescuento = new RendimientoPorDescuentoReal(laInformacionDeRendimiento).ComoNumero();
            }
            else
            {
                InformacionValorTransadoSinTratamiento laInformacionDeRendimiento = new InformacionValorTransadoSinTratamiento();
                laInformacionDeRendimiento.ValorFacial = elValorFacial;
                laInformacionDeRendimiento.ValorTransadoNeto = elValorTransadoNeto;
                laInformacionDeRendimiento.TasaDeImpuesto = laTasaDeImpuesto;
                laNuevaInversion.TasaNeta = laInformacionDeRendimiento.TasaNeta;
                laNuevaInversion.TasaBruta = new TasaBruta(laInformacionDeRendimiento).ComoNumero();
                laNuevaInversion.ValorTransadoBruto = laInformacionDeRendimiento.ValorTransadoBruto;
                laNuevaInversion.ImpuestoPagado = laInformacionDeRendimiento.Impuesto;
                laNuevaInversion.RendimientoPorDescuento = new RendimientoPorDescuentoReal(laInformacionDeRendimiento).ComoNumero();
            }

            laNuevaInversion.FechaDeValor = laFechaActual;
            laNuevaInversion.FechaDeVencimiento = laFechaDeVencimiento;

            return laNuevaInversion;
        }
    }
}
