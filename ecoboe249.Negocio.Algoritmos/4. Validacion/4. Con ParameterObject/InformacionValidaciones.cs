using System;

namespace ecoboe249.Negocio.Algoritmos.ConParameterObject.ValidacionesImpuesto
{
    public class InformacionValidaciones
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
    }
}
