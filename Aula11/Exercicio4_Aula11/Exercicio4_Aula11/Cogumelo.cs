using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Aula11
{
    class Cogumelo
    {
        public string poder;

        public Cogumelo()
        {
            poder = "Aumentar tamanho";
        }
        public void coletar(Collider2D collider)
        {
            Mario mario = new Mario();

            if (collider.gameObject.layer == 15)
            {
                mario.tamanho = "Grande";
                Console.WriteLine("O cogumelo foi coletado!");
                
            }
        }

    }
}
