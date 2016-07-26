using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
{
    public class InformacionDelCodigo
    {
        public DateTime Fecha { get; set; }
        public string NumeroDelCliente { get; set; }
        public string NumeroDelSistema { get; set; }
        public string NumeroDelConsecutivo { get; set; }

        public int ExtraigaElAño
        {
            get
            {
                return Fecha.Year;
            }
        }

        public int ExtraigaElDia
        {
            get
            {

                return Fecha.Day;
            }
        }

        public int ExtraigaElMes
        {
            get
            {
                return Fecha.Month;
            }
        }

        public string NumeroDelClienteFormateado
        {
            get
            {
                return NumeroDelCliente.PadLeft(3, '0');
            }
        }

        public string NumeroDelSistemaFormateado
        {
            get
            {
                return NumeroDelSistema.PadLeft(2, '0');
            }
        }

        public string NumeroConsecutivoFormateado
        {
            get
            {
                return NumeroDelConsecutivo.PadLeft(12, '0');
            }
        }
    }
}
