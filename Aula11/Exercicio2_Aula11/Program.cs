using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o nome do fúncionário: ");
            funcionario.nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto do fúncionário: ");
            funcionario.salariobruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma porcentagem para aumentar o salário do fúncionário: ");
            funcionario.porcentagem = double.Parse(Console.ReadLine());

            double imposto = funcionario.calcularImposto();
            Console.WriteLine(imposto);
            double salariobruto = funcionario.aumentarSalario();
            Console.WriteLine(salariobruto);
            double salarioliquido = funcionario.calcularSalarioLiquido(imposto, salariobruto);
            funcionario.mostrarDados(salarioliquido);

            //Console.ReadLine();

        }
    }
}
