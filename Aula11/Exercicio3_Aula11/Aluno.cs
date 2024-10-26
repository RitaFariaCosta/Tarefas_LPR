using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula11
{
    class Aluno
    {
        public int matricula;
        public string nome;
        public double notaprova1;
        public double notaprova2;
        public double notatrabalho;

        public double media()
        {
            double media = (((notaprova1 * 2.5) + (notaprova2 * 2.5) + (notatrabalho * 2.0))/7);
            return media;
        }
        public double final()
        {
            double mediaatual = media();
            
            if (mediaatual >= 7)
            {
                return 0;
            }
            else
            {
                double notanecessaria = 7 - mediaatual;
                return notanecessaria;
            }
        }
    }
}
