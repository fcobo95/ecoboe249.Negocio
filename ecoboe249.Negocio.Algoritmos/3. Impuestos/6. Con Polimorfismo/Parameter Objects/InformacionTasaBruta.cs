//using System;

//namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.Impuesto
//{
//    public abstract class InformacionTasaBruta : InformacionSobreImpuesto
//    {
//        public double DiasAlVencimientoComoNumero
//        {
//            get
//            {
//                return new DiasAlVencimiento(this).ComoNumero();
//            }
//        }

//        public abstract double Impuesto { get; }

//        internal double TasaNeta
//        {
//            get
//            {
//                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto
//                    * (DiasAlVencimientoComoNumero / 365))) * 100;
//            }
//        }
//    }
//}
