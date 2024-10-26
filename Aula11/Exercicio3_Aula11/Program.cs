using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno =  new Aluno();

            Console.WriteLine("Digite a matrícula do aluno: ");
            aluno.matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota de prova : ");
            aluno.notaprova1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota de prova: ");
            aluno.notaprova2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho: ");
            aluno.notatrabalho = int.Parse(Console.ReadLine());

            double media = aluno.media();
            double final = aluno.final();

            Console.WriteLine($"A média final do aluno foi de: {media.ToString("F2")} e o aluno precisa para a prova final: {final.ToString("F2")} pontos");

            Console.ReadLine();
        }
    }
}
