using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using GeometriaEspacial.Entidades.Enums;

namespace GeometriaEspacial.Entidades
{
    class Prisma : Poliedro
    {
        public Prisma(BasePoligono tipoBase, double altura, double arestaBase)
            : base(tipoBase, altura, arestaBase)
        {

        }

        public override double AreaBase()
        {
            return AreaPoligono(ArestaBase, TipoBase);
        }

        public override double AreaLateral()
        {
            return NumLados * ArestaBase * Altura;
        }

        public override double AreaTotal()
        {
            return AreaLateral() + 2 * AreaBase();
        }

        public override double Volume()
        {
            return AreaBase() * Altura;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prisma de base " + TipoBase);
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
