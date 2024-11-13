using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1_POO1
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double calArea()
        {
            return Altura * Largura;
        }

        public double calcPerimetro()
        {
            return (Altura + Largura) * 2;
        }
    }
}
