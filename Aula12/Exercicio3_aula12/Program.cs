using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(1, "João");
            Aluno aluno2 = new Aluno(2, "Maria");

            Turma turmaA = new Turma(101, "Matemática");
            Turma turmaB = new Turma(102, "História");

            // Matriculando alunos nas turmas
            aluno1.adicionarMatricula(turmaA);
            aluno2.adicionarMatricula(turmaA);
            aluno1.adicionarMatricula(turmaB);

            // Tentativa de matricular o mesmo aluno na mesma turma
            aluno1.adicionarMatricula(turmaA);

            turmaA.ListarAlunos();
            turmaB.ListarAlunos();

            Console.ReadLine();
        }
    }
}
