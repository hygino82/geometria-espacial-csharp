using GeometriaEspacial.Entidades.Enums;
using System;
using System.Text;
using System.Globalization;

namespace GeometriaEspacial.Entidades
{
    class TroncoPiramide : Poliedro
    {
        public double ArestaMenor { get; set; }

        public TroncoPiramide(BasePoligono tipoBase, double altura, double arestaBase, double arestamenor)
          : base(tipoBase, altura, arestaBase)
        {
            ArestaMenor = arestamenor;
        }

        public double AreaBaseMenor()
        {
            return AreaPoligono(ArestaMenor, TipoBase);
        }

        public override double AreaBase()
        {
            return AreaPoligono(ArestaBase, TipoBase);
        }

        public override double AreaLateral()
        {
            double l1 = ArestaBase;
            double l2 = ArestaMenor;
            double h = Altura;
            double m1 = 0, m2 = 0;//inicializando
            double g;
            double area = 0;// inicializar

            switch (NumLados)
            {
                case 1:
                    double dif = Math.Abs(l1 - l2);
                    g = Math.Sqrt(Math.Pow(dif, 2.0) + Math.Pow(h, 2.0));
                    area = Math.PI * g * (l1 + l2);
                    break;
                case 4:
                    m1 = l1 / 2.0;
                    m2 = l2 / 2.0;
                    break;
                case 6:
                    m1 = l1 * Math.Sqrt(3) / 2.0;
                    m2 = l2 * Math.Sqrt(3) / 2.0;
                    break;
                default://triangulo equilátero
                    m1 = l1 * Math.Sqrt(3) / 6.0;
                    m2 = l2 * Math.Sqrt(3) / 6.0;
                    break;
            }

            if (NumLados != 1)
            {
                double dif = Math.Abs(m1 - m2);
                g = Math.Sqrt(Math.Pow(dif, 2.0) + Math.Pow(h, 2.0));
                area = NumLados * (l1 + l2) * g / 2.0;
            }
            return area;
        }

        public override double AreaTotal()
        {
            return AreaBase() + AreaBaseMenor() + AreaLateral();
        }

        public override double Volume()
        {
            return Altura * (AreaBase() + AreaBaseMenor() + Math.Sqrt(AreaBase() * AreaBaseMenor())) / 3.0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tronco de pirâmide de base " + TipoBase);
            sb.AppendLine("Aresta da base maior: " + ArestaBase.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Aresta da base menor: " + ArestaMenor.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Altura: " + Altura.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área da base maior: " + AreaBase().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área da base menor: " + AreaBaseMenor().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área lateral: " + AreaLateral().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Área total: " + AreaTotal().ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("Volume: " + Volume().ToString("F4", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
