using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.CodigosDeReferencia
{
    public class InformacionDelCodigo
    {
        public DateTime Fecha { get; set; }
        public string NumeroDelCliente { get; set; }
        public string NumeroDelSistema { get; set; }
        public string NumeroDelConsecutivo { get; set; }

        public int Año
        {
            get
            {
                return Fecha.Year;
            }
        }

        public int Dia
        {
            get
            {

                return Fecha.Day;
            }
        }

        public int Mes
        {
            get
            {
                return Fecha.Month;
            }
        }

        public string ClienteFormateado
        {
            get
            {
                return NumeroDelCliente.PadLeft(3, '0');
            }
        }

        public string SistemaFormateado
        {
            get
            {
                return NumeroDelSistema.PadLeft(2, '0');
            }
        }

        public string ConsecutivoFormateado
        {
            get
            {
                return NumeroDelConsecutivo.PadLeft(12, '0');
            }
        }
    }
}
