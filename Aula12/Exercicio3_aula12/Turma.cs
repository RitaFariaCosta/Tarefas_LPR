using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_aula12
{
    internal class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Matricula> Matriculas { get; set; } // lista de matriculas para estabelecer um relacionamento N x N entre as classes Aluno e Turma

        public Turma(int iD, string nome)
        {
            this.Id = iD;
            this.Nome = nome;
            Matriculas = new List<Matricula>();
        }

        public bool AdicionarMatricula(Aluno aluno)
        {
            // Verifica se o aluno já está matriculado na turma usando foreach
            foreach (var matricula in Matriculas)
            {
                if (matricula.aluno.Id == aluno.Id)
                {
                    Console.WriteLine($"O aluno {aluno.Nome} já está matriculado nesta turma.");
                    return false;
                }
            }

            // Cria uma nova matrícula e adiciona à lista de matrículas do aluno e da turma
            var novaMatricula = new Matricula(aluno, this);
            Matriculas.Add(novaMatricula);
            aluno.Matriculas.Add(novaMatricula);
            Console.WriteLine($"Aluno {aluno.Nome} matriculado na turma {Nome}");
            return true;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"\nAlunos matriculados na turma {Nome}:");
            foreach (Matricula matricula in Matriculas)
            {
                Console.WriteLine($"Nome:{matricula.aluno.Nome}");
                //Console.WriteLine($"{matricula.aluno.Turma}");
                Console.WriteLine($"Data:{matricula.data}/{matricula.mes}/{matricula.ano}");
            }
        }
    }
}
