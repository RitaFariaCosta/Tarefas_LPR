using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula11
{
    public class Retangulo
    {
        public double altura;
        public double largura;

        public double calcArea()
        {
            double area = altura * largura;
            return area;
        }

        public double calcPerimetro()
        {
            double perimetro = (2 * altura) + (2 * largura);
            return perimetro;
        }
    }
}