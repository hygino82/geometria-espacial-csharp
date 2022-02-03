using GeometriaEspacial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaEspacial.Entidades
{
    abstract class Poliedro
    {
        public BasePoligono TipoBase { get; private set; }
        public double Altura { get; set; }
        public double ArestaBase { get; set; }

        public int NumLados { get; private set; }

        protected Poliedro()
        {
        }

        protected Poliedro(BasePoligono tipoBase, double altura, double arestaBase)
        {
            TipoBase = tipoBase;
            Altura = altura;
            ArestaBase = arestaBase;
            if (tipoBase == BasePoligono.Quadrado)
            {
                NumLados = 4;
            }
            else if (tipoBase == BasePoligono.TrianguloEquilatero)
            {
                NumLados = 3;
            }
            else if (tipoBase == BasePoligono.HexagonoRegular)
            {
                NumLados = 6;
            }
            else
            {
                NumLados = 1;
            }
        }

        public double AreaPoligono(double aresta, BasePoligono tipoBase)
        {
            double area;

            switch (tipoBase)
            {
                case BasePoligono.Quadrado:
                    area = Math.Pow(aresta, 2.0);
                    break;
                case BasePoligono.TrianguloEquilatero:
                    area = Math.Pow(aresta, 2.0) * Math.Sqrt(3.0) / 4.0;
                    break;
                case BasePoligono.HexagonoRegular:
                    area = 3 * Math.Pow(aresta, 2.0) * Math.Sqrt(3.0) / 2.0;
                    break;
                default:
                    area = Math.Pow(aresta, 2.0) * Math.PI;
                    break;

            }
            return area;
        }

        public abstract double AreaBase();
        public abstract double AreaLateral();
        public abstract double AreaTotal();
        public abstract double Volume();
    }
}
