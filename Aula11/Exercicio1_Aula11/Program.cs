using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.altura = double.Parse(Console.ReadLine());
     
            Console.WriteLine("Digite a largura do retângulo: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            double area = retangulo.calcArea();
            double perimetro = retangulo.calcPerimetro();

            Console.WriteLine($"Área do retângulo: {area.ToString("F2")}");
            Console.WriteLine($"Perímetro do retângulo: {perimetro.ToString("F2")}");

            Console.ReadLine();
        }
    }
}