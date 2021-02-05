using GeometriaEspacial.Entidades;
using GeometriaEspacial.Entidades.Enums;
using System;

namespace GeometriaEspacial
{
    class Program
    {
        static void Main(string[] args)
        {
            Poliedro pol1 = new Prisma(BasePoligono.Quadrado, 12.0, 10.0);
            Console.WriteLine(pol1);
        }
    }
}
