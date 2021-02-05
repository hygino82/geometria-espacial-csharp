using GeometriaEspacial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaEspacial.Entidades
{
    abstract class Poliedro
    {
        public BasePoligono TipoBase { get; private set; }
        public double Altura { get; set; }
        public double ArestaBase { get; set; }
        
        protected Poliedro()
        {
        }

        protected Poliedro(BasePoligono tipoBase, double altura, double arestaBase)
        {
            TipoBase = tipoBase;
            Altura = altura;
            ArestaBase = arestaBase;
        }
    }
}
