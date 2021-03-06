﻿using System;

namespace ecoboe249.Negocio.Algoritmos.ConPolimorfismo.CodigosDeReferencia
{
    public class Año
    {
        private int elAño;

        public Año(InformacionDelCodigo elCodigo)
        {
            elAño = ObtengaElAño(elCodigo);
        }

        private static int ObtengaElAño(InformacionDelCodigo elCodigo)
        {
            return elCodigo.Año;
        }

        public string ComoTexto()
        {
            return Convert.ToString(elAño);
        }
    }
}
