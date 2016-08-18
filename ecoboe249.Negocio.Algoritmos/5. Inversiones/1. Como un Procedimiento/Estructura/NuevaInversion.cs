﻿using System;

namespace ecoboe249.Negocio.Algoritmos.ComoUnProcedimiento.GeneracionDeInversiones
{
    public class NuevaInversion
    {
        public string CodigoDeReferencia { get; set; }
        public double TasaNeta { get; set; }
        public double TasaBruta { get; set; }
        public double ValorTransadoBruto { get; set; }
        public double ImpuestoPagado { get; set; }
        public double RendimientoPorDescuento { get; set; }
        public DateTime FechaDeValor { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
    }
}