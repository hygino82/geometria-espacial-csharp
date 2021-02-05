using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaEspacial.Entidades
{
    class Prisma:Poliedro
    {
        public double AreaBase()
        {
            double area;
            if (TipoBase == Enums.BasePoligono.Quadrado)
            {
                area = Math.Pow(ArestaBase, 2.0);
            }
            else if(TipoBase == Enums.BasePoligono.TrianguloEquilatero)
            {
                area = Math.Pow(ArestaBase, 2.0) * Math.Sqrt(3.0) / 4.0;
            }
            else if (TipoBase == Enums.BasePoligono.HexagonoRegular)
            {
                area = 3 * Math.Pow(ArestaBase, 2.0) * Math.Sqrt(3.0) / 2.0;
            }
            else
            {
                area = Math.Pow(ArestaBase, 2.0) * Math.PI;
            }
            return area;
        }
    }
}
