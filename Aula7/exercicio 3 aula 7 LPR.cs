//EXERCICIO 3 AULA 7 LPR - possui erros, mas eu tentei
using System;

class Program
{
    static void Main()
    {
        string nomeHeroi1 = "", poderHeroi1 = "", nomeHeroi2 = "", poderHeroi2 = "", nomeHeroi3 = "", poderHeroi3 = "";
        string nomeHeroi4 = "", poderHeroi4 = "", nomeHeroi5 = "", poderHeroi5 = "";
        string equipeNome1 = "", equipePoder1 = "", equipeNome2 = "", equipePoder2 = "", equipeNome3 = "", equipePoder3 = "";
        int pontuacao1 = 0, pontuacao2 = 0, pontuacao3 = 0, pontuacao4 = 0, pontuacao5 = 0;
        int pontuacaoTotalEquipe = 0;

        while (true)
        {
            MenuPrincipal();
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarHeroi(ref nomeHeroi1, ref poderHeroi1, ref nomeHeroi2, ref poderHeroi2, ref nomeHeroi3, ref poderHeroi3,ref nomeHeroi4, ref poderHeroi4, ref nomeHeroi5, ref poderHeroi5, ref pontuacao1, ref pontuacao2,ref pontuacao3,ref pontuacao4,ref pontuacao5);
                    break;
                case 2:
                    SelecionarEquipe(ref equipeNome1, ref equipePoder1, ref equipeNome2, ref equipePoder2, ref equipeNome3, ref equipePoder3,nomeHeroi1, poderHeroi1, nomeHeroi2, poderHeroi2, nomeHeroi3, poderHeroi3, nomeHeroi4, poderHeroi4, nomeHeroi5, poderHeroi5, pontuacao1, pontuacao2, pontuacao3, pontuacao4, pontuacao5);
                    break;
                case 3:
                    ExibirEquipe(equipeNome1, equipePoder1, equipeNome2, equipePoder2, equipeNome3, equipePoder3, pontuacaoTotalEquipe);
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa..."); 
                    break;
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

    static void CadastrarHeroi(ref string nome1, ref string poder1, ref string nome2, ref string poder2, ref string nome3, ref string poder3,ref string nome4, ref string poder4, ref string nome5, ref string poder5, ref float pontuacao1, ref float pontuacao2, ref float pontuacao3, ref float pontuacao4, ref float pontuacao5)
    {
        Console.WriteLine("\n------ Cadastro de Herói ------");

        Console.WriteLine("Herói 1:");
        Console.Write("Nome: ");
        nome1 = Console.ReadLine();
        Console.Write("Poder: ");
        poder1 = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontuacao1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Herói 2:");
        Console.Write("Nome: ");
        nome2 = Console.ReadLine();
        Console.Write("Poder: ");
        poder2 = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontuacao2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Herói 3:");
        Console.Write("Nome: ");
        nome3 = Console.ReadLine();
        Console.Write("Poder: ");
        poder3 = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontuacao3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Herói 4:");
        Console.Write("Nome: ");
        nome4 = Console.ReadLine();
        Console.Write("Poder: ");
        poder4 = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontuacao4 = float.Parse(Console.ReadLine());

        Console.WriteLine("Herói 5:");
        Console.Write("Nome: ");
        nome5 = Console.ReadLine();
        Console.Write("Poder: ");
        poder5 = Console.ReadLine();
        Console.Write("Pontuação: ");
        pontuacao5 = float.Parse(Console.ReadLine());
    }

    static void SelecionarEquipe(ref string equipeNome1, ref string equipePoder1, ref float equipePontuacao1, ref string equipeNome2, ref string equipePoder2, ref float equipePontuacao2, ref string equipeNome3, ref string equipePoder3, ref float equipePontuacao3,string nomeHeroi1, string poderHeroi1, string nomeHeroi2, string poderHeroi2, string nomeHeroi3, string poderHeroi3,string nomeHeroi4, string poderHeroi4, string nomeHeroi5, string poderHeroi5, float pontuacao1, float pontuacao2, float pontuacao3, float pontuacao4, float pontuacao5)
    {
        Console.WriteLine("\n------ Seleção de Equipe ------");
        Console.WriteLine("Heróis cadastrados:");
        Console.WriteLine($"1. {nomeHeroi1} - {poderHeroi1} - {pontuacao1}");
        Console.WriteLine($"2. {nomeHeroi2} - {poderHeroi2} - {pontuacao2}");
        Console.WriteLine($"3. {nomeHeroi3} - {poderHeroi3} - {pontuacao3}");
        Console.WriteLine($"4. {nomeHeroi4} - {poderHeroi4} - {pontuacao4}");
        Console.WriteLine($"5. {nomeHeroi5} - {poderHeroi5} - {pontuacao5}");

        Console.WriteLine("Selecione 3 heróis para sua equipe:");

        Console.Write("Selecione o herói 1: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice == 1)
        {
            equipeNome1 = nomeHeroi1;
            equipePoder1 = poderHeroi1;
            equipePontuacao1 = pontuacao1;
        }
        else if (indice == 2)
        {
            equipeNome1 = nomeHeroi2;
            equipePoder1 = poderHeroi2;
            equipePontuacao1 = pontuacao2;
        }
        else if (indice == 3)
        {
            equipeNome1 = nomeHeroi3;
            equipePoder1 = poderHeroi3;
            equipePontuacao1 = pontuacao3;
        }
        else if (indice == 4)
        {
            equipeNome1 = nomeHeroi4;
            equipePoder1 = poderHeroi4;
            equipePontuacao1 = pontuacao4;
        }
        else if (indice == 5)
        {
            equipeNome1 = nomeHeroi5;
            equipePoder1 = poderHeroi5;
            equipePontuacao1 = pontuacao5;
        }

        Console.Write("Selecione o herói 2: ");
        indice = int.Parse(Console.ReadLine());

        if (indice == 1)
        {
            equipeNome2 = nomeHeroi1;
            equipePoder2 = poderHeroi1;
            equipePontuacao2 = pontuacao1;
        }
        else if (indice == 2)
        {
            equipeNome2 = nomeHeroi2;
            equipePoder2 = poderHeroi2;
            equipePontuacao2 = pontuacao2;
        }
        else if (indice == 3)
        {
            equipeNome2 = nomeHeroi3;
            equipePoder2 = poderHeroi3;
            equipePontuacao2 = pontuacao3;
        }
        else if (indice == 4)
        {
            equipeNome2 = nomeHeroi4;
            equipePoder2 = poderHeroi4;
            equipePontuacao2 = pontuacao4;
        }
        else if (indice == 5)
        {
            equipeNome2 = nomeHeroi5;
            equipePoder2 = poderHeroi5;
            equipePontuacao2 = pontuacao5;
        }

        Console.Write("Selecione o herói 3: ");
        indice = int.Parse(Console.ReadLine());

        if (indice == 1)
        {
            equipeNome3 = nomeHeroi1;
            equipePoder3 = poderHeroi1;
            equipePontuacao3 = pontuacao1;
        }
        else if (indice == 2)
        {
            equipeNome3 = nomeHeroi2;
            equipePoder3 = poderHeroi2;
            equipePontuacao3 = pontuacao2;
        }
        else if (indice == 3)
        {
            equipeNome3 = nomeHeroi3;
            equipePoder3 = poderHeroi3;
            equipePontuacao3 = pontuacao3;
        }
        else if (indice == 4)
        {
            equipeNome3 = nomeHeroi4;
            equipePoder3 = poderHeroi4;
            equipePontuacao3 = pontuacao4;
        }
        else if (indice == 5)
        {
            equipeNome3 = nomeHeroi5;
            equipePoder3 = poderHeroi5;
            equipePontuacao3 = pontuacao5;
        }
    }

    static void ExibirEquipe(string equipeNome1, string equipePoder1, string equipeNome2, string equipePoder2, string equipeNome3, string equipePoder3, float pontuacaoTotalEquipe)
    {
        Console.WriteLine("\n------ Equipe ------");
        Console.WriteLine($"Herói 1: {equipeNome1} - {equipePoder1}");
        Console.WriteLine($"Herói 2: {equipeNome2} - {equipePoder2}");
        Console.WriteLine($"Herói 3: {equipeNome3} - {equipePoder3}");

        pontuacaoTotalEquipe = CalcularPontuacaoTotal(equipeNome1, equipeNome2, equipeNome3);
        Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotalEquipe}");
    }

    static float CalcularPontuacaoTotal(float equipePontuacao1,float equipePontuacao2,float equipePontuacao3)
    {
        Console.WriteLine("\n------ Calculando Pontuação Total da Equipe ------");
        

        return equipePontuacao1+equipePontuacao2+equipePontuacao3;
}
}
