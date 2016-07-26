using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoboe249.Negocio.Algoritmos.ConTellDontAsk.ValidacionesImpuesto
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
