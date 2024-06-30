using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    float soma = 0;
    Dictionary<string, int> idadeDasPessoas = new Dictionary<string, int>();

    Console.Write("Digite a quantidade de pessoas: ");
    int quantidade = int.Parse(Console.ReadLine());

    for(int i = 0; i < quantidade; i++){
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        idadeDasPessoas.Add(nome, idade);
        soma += idade;
        
    }
    float media = soma/quantidade;
    
    Console.WriteLine("\nPessoas com idade acima da média: ");
    foreach (var pessoa in idadeDasPessoas){
         if (pessoa.Value > media){
        Console.WriteLine($"{pessoa.Key}");
        }
    }
        string pessoaMaisVelha = null;
        int maiorIdade = int.MinValue;

        string pessoaMaisNova = null;
        int menorIdade = int.MaxValue;

        foreach (var pessoa in idadeDasPessoas)
        {
            if (pessoa.Value > maiorIdade)
            {
                maiorIdade = pessoa.Value;
                pessoaMaisVelha = pessoa.Key;
            }
            if (pessoa.Value < menorIdade)
            {
                menorIdade = pessoa.Value;
                pessoaMaisNova = pessoa.Key;
            }
        }
        Console.WriteLine($"\nPessoa mais velha: {pessoaMaisVelha}, idade: {maiorIdade} anos");
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova}, idade: {menorIdade} anos");

        Console.WriteLine("\nDigite uma idade para remover: ");
        int numRemover = int.Parse(Console.ReadLine());
        
        List<string> chavesARemover = new List<string>();

        foreach (var pessoa in idadeDasPessoas)
        {
            if (pessoa.Value == numRemover)
            {
                chavesARemover.Add(pessoa.Key);
            }
        }

        foreach (var chave in chavesARemover)
        {
            idadeDasPessoas.Remove(chave);
        }
        
        foreach (var people in idadeDasPessoas)
        {
         Console.WriteLine($"Pessoas: {people.Key}, Idade: {people.Value}");
        }
  }
}
