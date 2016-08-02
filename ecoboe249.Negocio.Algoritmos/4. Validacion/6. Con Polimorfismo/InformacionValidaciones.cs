using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.ValidacionesImpuesto
{
    public class InformacionValidaciones
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }

        public bool ValorFacialEsValido()
        {
            if (ValorFacial > 100000)
                return true;
            else
                return false;
        }

        public bool ValorTransadoNetoEsValido()
        {
            if (ValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        public bool TasaDeImpuestoEsValido()
        {
            if (TasaDeImpuesto < 1 & TasaDeImpuesto > 0)
                return true;
            else
                return false;
        }

        public bool FechaEsValida()
        {
            if (FechaActual < FechaDeVencimiento)
                return true;
            else
                return false;
        }
    }
}
