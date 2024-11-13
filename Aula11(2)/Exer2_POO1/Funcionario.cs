using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2_POO1
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public double salarioBruto { get; set; }
        public double salarioLiquido { get; set; }
        public double porcentagem { get; set; }

        public Funcionario(string nome, double salarioBruto, double porcentagem)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.porcentagem = porcentagem;
        }
        public void mostrarDados()
        {
            Console.WriteLine($"Dados do funcionário {nome}: ");
            Console.WriteLine($"Salário Líquido: {salarioLiquido}");

        }
        public double aumentarSalario()
        {
            if (salarioBruto <= 2000)
            {
                return salarioLiquido = salarioBruto + ((porcentagem / 100) * salarioBruto) - (0.10 * salarioBruto) ;

            }
            else if(salarioBruto <= 3000)
            {
                return salarioLiquido = salarioBruto + ((porcentagem / 100) * salarioBruto) - (0.15 * salarioBruto);
            }
            else
            {
                return salarioLiquido = salarioBruto  + ((porcentagem / 100) * salarioBruto) - (0.20 * salarioBruto);
            }
        }

    }
}
