using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_aula1
{
    public class andery
    {
        public int atributo1;
        public string atributo2;

        //construtor abaixo
        public ClasseExemplo(int a1)
        {
            atributo1 = a1;
            atributo2 = "fIXO!";
        }
        public void metodoImprimir()
        {
            Console.WriteLine("Método Imprimir");
            Console.WriteLine(atributo2);
        }
    }
}