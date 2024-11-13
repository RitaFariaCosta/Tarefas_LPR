using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3_POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Rita", 7.5, 9.0, 9.5);
            Aluno a2 = new Aluno("Gabi", 8.0, 6.0, 10.0);

            double media1 = a1.calcularMedia();
            double final1 = a1.final();

            double media2 = a2.calcularMedia();
            double final2 = a2.final();

            Console.WriteLine($"A média do(a) estudante {a1.nome} é {media1.ToString("F2")}");
            Console.WriteLine($"O(a) estudante {a1.nome} precisa de {final1.ToString("F2")} pontos para passar");

            Console.WriteLine($"\nA média do(a) estudante {a2.nome} é {media2.ToString("F2")}");
            Console.WriteLine($"O(a) estudante {a2.nome} precisa de {final2.ToString("F2")} pontos para passar");

            Console.ReadLine();
        }
    }
}
