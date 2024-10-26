using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula11
{
    public class Funcionario
    {
        public string nome;
        public double salariobruto;
        public double porcentagem;
        public double imposto;
        public double salarioliquido;

        public double calcularImposto()
        {
            if (salariobruto <= 2000)
            {
                imposto = ((10.0 / 100) * salariobruto);
            }
            else if (salariobruto <= 3000)
            {
                imposto = ((15.0 / 100) * salariobruto);
            }
            else if (salariobruto > 3000)
            {
                imposto = ((20.0 / 100) * salariobruto);
            }
            return imposto;
        }

        public double aumentarSalario()
        {
            salariobruto = salariobruto + (salariobruto * (porcentagem / 100));
            return salariobruto;
        }

        public double calcularSalarioLiquido(double imposto, double salariobruto)
        {
            double salarioliquido = salariobruto - imposto;
            return salarioliquido;
        }

        public void mostrarDados(double salarioliquido)
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário líquido: {salarioliquido}");
        }
    }
}