using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2_POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome, o salário bruto do funcionário e a porcentagem para aumentar o salário");
            Funcionario funcionario = new Funcionario(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            funcionario.aumentarSalario();
            funcionario.mostrarDados();

            Console.ReadLine();

        }
    }
}
