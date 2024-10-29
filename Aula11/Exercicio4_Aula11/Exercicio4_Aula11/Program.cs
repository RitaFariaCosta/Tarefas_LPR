using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            Inimigo inimigo = new Inimigo();
            //layer mario = 15, inimigo = 16 e cogumelo = 17;
            Console.WriteLine("Digite a quantidade de vidas do personagem principal");
            mario.vidas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de vidas do inimigo");
            inimigo.vida = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
