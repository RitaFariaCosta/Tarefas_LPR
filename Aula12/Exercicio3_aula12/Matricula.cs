using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_aula12
{
    internal class Matricula
    {
        public Aluno aluno { get; set; }
        public Turma turma { get; set; }
        public int data { get;}
        public int mes { get; }
        public int ano { get; }

        static int cont = 1;

        public Matricula(Aluno aluno, Turma turma)
        {
            this.aluno = aluno;
            this.turma = turma;
            this.data = cont;
            this.mes = 5;
            this.ano = 2024;
            cont++;
        }
    }
}
