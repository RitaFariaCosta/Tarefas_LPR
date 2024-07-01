using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Solicita ao usuário a quantidade de nomes que ele quer inserir
        Console.WriteLine("Digite a quantidade de nomes que deseja inserir:");
        int quantidade = int.Parse(Console.ReadLine());

        // Cria uma lista para armazenar os nomes
        List<string> nomes = new List<string>();

        // Solicita ao usuário que digite os nomes
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nomes.Add(Console.ReadLine());
        }

        // Ordena a lista de nomes pelo comprimento e pela ordem original de digitação
        var nomesOrdenados = nomes.Select((nome, index) => new { Nome = nome, Index = index })
                                  .OrderBy(n => n.Nome.Length)
                                  .ThenBy(n => n.Index)
                                  .ToList();

        // Variáveis para armazenar nomes únicos e repetidos
        List<string> nomesUnicos = new List<string>();
        List<string> nomesRepetidos = new List<string>();

        // Dicionário para contar ocorrências dos comprimentos dos nomes
        Dictionary<int, int> comprimentoContagem = new Dictionary<int, int>();

        // Percorre a lista de nomes ordenados
        foreach (var nome in nomesOrdenados)
        {
            int comprimento = nome.Nome.Length;
            if (comprimentoContagem.ContainsKey(comprimento))
            {
                // Se o comprimento já existe no dicionário, incrementa a contagem
                comprimentoContagem[comprimento]++;
                nomesRepetidos.Add(nome.Nome);
            }
            else
            {
                // Se o comprimento não existe no dicionário, adiciona ao dicionário e à lista de nomes únicos
                comprimentoContagem[comprimento] = 1;
                nomesUnicos.Add(nome.Nome);
            }
        }

        // Imprime a linha de nomes únicos
        Console.WriteLine(string.Join(", ", nomesUnicos));

        // Processa os nomes repetidos para exibir em linhas separadas por comprimento
        while (nomesRepetidos.Count > 0)
        {
            List<string> linhaAtual = new List<string>();
            int comprimentoAnterior = -1;

            for (int i = 0; i < nomesRepetidos.Count; i++)
            {
                var nome = nomesRepetidos[i];
                if (comprimentoAnterior == -1 || nome.Length != comprimentoAnterior)
                {
                    linhaAtual.Add(nome);
                    comprimentoAnterior = nome.Length;
                    nomesRepetidos.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", linhaAtual));
        }
    }
}


