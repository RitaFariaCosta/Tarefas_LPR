using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1_POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura e a largura do retângulo: ");
            Retangulo retangulo = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            double area = retangulo.calArea();
            double perimetro = retangulo.calcPerimetro();

            Console.WriteLine($"A área do retângulo é {area} cm");
            Console.WriteLine($"O perímetro do retângulo é {perimetro} cm");

            Console.ReadLine();
        }
    }
}
