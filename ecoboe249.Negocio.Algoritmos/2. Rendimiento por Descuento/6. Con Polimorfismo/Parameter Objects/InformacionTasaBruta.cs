using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.RendimientoPorDescuentos
{
    public abstract class InformacionTasaBruta : InformacionDelRendimiento
    {
        private DateTime Año;

        //public int losDiasDelAño
        //{
        //    get
        //    {
        //        if (DateTime.IsLeapYear(Año))
        //            return 366;
        //        else
        //            return 365;
        //    }
        //}

        public double DiasAlVencimientoComoNumero
        {
            get
            {
                return new DiasAlVencimiento(this).ComoNumero();
            }
        }

        public abstract double Impuesto { get; }
        public abstract double ValorTransadoBruto { get; }

        internal double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                       (DiasAlVencimientoComoNumero / 365))) * 100;
            }
        }
    }
}
