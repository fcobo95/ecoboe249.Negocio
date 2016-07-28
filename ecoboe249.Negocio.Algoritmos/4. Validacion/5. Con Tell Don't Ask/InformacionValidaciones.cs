using System;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.ValidacionesImpuesto
{
    public class InformacionValidaciones
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool ValorFacialValidado
        {
            get
            {
                if (ValorFacial > 100000)
                    return true;
                else
                    return false;
            }
        }

        public bool ValorTransadoNetoValidado
        {
            get
            {
                if (ValorTransadoNeto > 100000)
                    return true;
                else
                    return false;
            }
        }

        public bool TasaDeImpuestoValidada
        {
            get
            {
                if (TasaDeImpuesto < 1 & TasaDeImpuesto > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool FechaValidada
        {
            get
            {
                if (FechaActual < FechaDeVencimiento)
                    return true;
                else
                    return false;
            }
        }
    }
}
