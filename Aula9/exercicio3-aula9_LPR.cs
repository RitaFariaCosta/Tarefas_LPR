using System;

class Program
   {
    public struct Herois {
    public string Nome;
    public string Poder;
    public int Pontuacao;
    }
    
   static Herois[] herois = new Herois[5];    
   static Herois[] equipe = new Herois[3];
   static int quantidadeHerois = 0;
 
  static void Main(string[] args)
  {

    while (true)
    {
        MenuPrincipal();
        int opcao = int.Parse(Console.ReadLine());
         switch (opcao)
        {
         case 1:
           CadastrarHeroi();
           break;
         case 2:
           SelecionarEquipe();
           break;
         case 3:
           ExibirEquipe();
           break;
         case 4:
           Console.WriteLine("Saindo do programa..."); 
           return;
         default:
           Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
           break;
        }
    }
  }

  static void MenuPrincipal()
  {
    Console.WriteLine("\n------ Menu ------");
    Console.WriteLine("1. Cadastrar Herói");
    Console.WriteLine("2. Selecionar Equipe");
    Console.WriteLine("3. Exibir Equipe");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
  }

  static void CadastrarHeroi()
  {
      if (quantidadeHerois < 5)
        {
            Console.WriteLine("\n------ Cadastro de Herói ------");
            Console.Write("Nome: ");
            herois[quantidadeHerois].Nome = Console.ReadLine();
            Console.Write("Poder: ");
            herois[quantidadeHerois].Poder = Console.ReadLine();
            Console.Write("Pontuação: ");
            herois[quantidadeHerois].Pontuacao = int.Parse(Console.ReadLine());

            quantidadeHerois++;
            Console.WriteLine("Herói cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Você já cadastrou o número máximo de 5 heróis.");
        }
  }

  static void SelecionarEquipe()
  {
      if (quantidadeHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis antes de selecionar a equipe.");
            return;
        }
        
      Console.WriteLine("\n------ Seleção de Equipe ------");
      for (int i = 0; i < quantidadeHerois; i++)
        {
            Console.WriteLine($"{i + 1}. {herois[i].Nome} - {herois[i].Poder} - Pontuação: {herois[i].Pontuacao}");
        }
      
      for (int i = 0; i < 3; i++)
        {
            Console.Write($"Selecione o herói {i + 1}: ");
            int selecao = int.Parse(Console.ReadLine()) - 1;
            if (selecao >= 0 && selecao < quantidadeHerois)
            {
                equipe[i] = herois[selecao];
            }
            else
            {
                Console.WriteLine("Seleção inválida. Tente novamente.");
                i--;
            }
        }
      Console.WriteLine("Equipe selecionada com sucesso!");
  }

  static void ExibirEquipe()
  {
     if (quantidadeHerois < 3)
        {
            Console.WriteLine("A equipe ainda não foi totalmente selecionada.");
            return;
        }
        
    Console.WriteLine("\n------ Equipe ------");
    int pontuacaoTotalEquipe = CalcularPontuacaoTotal();
    
    for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1}. {equipe[i].Nome} - {equipe[i].Poder} - Pontuação: {equipe[i].Pontuacao}");
        }
        
    Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotalEquipe}");
  }

   static int CalcularPontuacaoTotal()
    {
       int pontuacaototal = 0;
       for (int i = 0; i < 3; i++)
        {
            pontuacaototal += equipe[i].Pontuacao;
        }
        return pontuacaototal;
    }
  }