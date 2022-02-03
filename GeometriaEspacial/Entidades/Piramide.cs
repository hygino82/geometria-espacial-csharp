using GeometriaEspacial.Entidades;
using GeometriaEspacial.Entidades.Enums;
using System;
using System.Globalization;
using System.Text;

namespace GeometriaEspacial
{
    class Piramide : Poliedro
    {

        public Piramide(BasePoligono tipoBase, double altura, double arestaBase)
          : base(tipoBase, altura, arestaBase)
        {

        }

        public override double AreaBase()
        {
            return AreaPoligono(ArestaBase, TipoBase);
        }

        public override double AreaLateral()
        {
            double m, g;
            double area;
            double l = ArestaBase;
            double h = Altura;

            switch (NumLados)
            {
                case 1:
                    g = Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(h, 2.0));
                    area = Math.PI * l * g;
                    break;
                case 4:
                    m = l / 2.0;
                    g = Math.Sqrt(Math.Pow(h, 2.0) + Math.Pow(m, 2.0));
                    area = 4 * l * g / 2.0;
                    break;
                case 6:
                    m = l * Math.Sqrt(3) / 2.0;
                    g = Math.Sqrt(Math.Pow(h, 2.0) + Math.Pow(m, 2.0));

                    area = 6 * l * g / 2.0;
                    break;
                default:// triangulo equilatero
                    m = ArestaBase * Math.Sqrt(3) / 6.0;
                    g = Math.Sqrt(Math.Pow(Altura, 2.0) + Math.Pow(m, 2.0));
                    area = 3 * l * g / 2.0;
                    break;
            }
            return area;
        }

        public override double AreaTotal()
        {
            return AreaBase() + AreaLateral();
        }

        public override double Volume()
        {
            return AreaBase() * Altura / 3.0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Pirâmide de base " + TipoBase);
            sb.AppendLine("Aresta da base: " + ArestaBase.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Altura: " + Altura.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área da base: " + AreaBase().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área lateral: " + AreaLateral().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área total: " + AreaTotal().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Volume: " + Volume().ToString("F4", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
