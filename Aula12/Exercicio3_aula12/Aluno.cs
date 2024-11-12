using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_aula12
{
    internal class Aluno
    {
       public int Id { get; set; }
       public string Nome { get; set; }
       public List<Matricula> Matriculas { get; set; } // lista de matriculas para estabelecer um relacionamento N x N entre as classes Aluno e Turma

        public Aluno(int id,string nome)
        {
            this.Id = id;
            this.Nome = nome;
            Matriculas = new List<Matricula>();
        }

        public bool adicionarMatricula(Turma turma)
        {
            foreach (var matricula in Matriculas)
            {
                if (matricula.turma.Id == turma.Id)
                {
                    Console.WriteLine($"{Nome} já está matriculado na turma {turma.Nome}");
                    return false;
                }
            }
            var novaMatricula = new Matricula(this, turma);
            Matriculas.Add(novaMatricula);
            turma.Matriculas.Add(novaMatricula);
            Console.WriteLine($"{Nome} foi matriculado na turma {turma.Nome}");
            return true;
        }
    }
}
