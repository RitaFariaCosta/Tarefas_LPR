using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3_POO1
{
    internal class Aluno
    {
        public int matricula { get; }
        public string nome { get; set; }
        public double prova1 { get; set; }
        public double prova2 { get; set; }
        public double trabalho { get; set; }
        public double media { get; set; }

        public Aluno(string nome, double prova1, double prova2, double trabalho)
        {
            this.nome = nome;
            this.prova1 = prova1;
            this.prova2 = prova2;
            this.trabalho = trabalho;
        }
        public double calcularMedia()
        {
            media = ((prova1 * 2.5) + (prova2 * 2.5) + (trabalho * 2.0))/7;
            return media;
                
        }
        public double final()
        {
            if (media >=7)
            {
                return 0;
            }
            else
            {
                return 7 - media;
            }
        }
    }

}
