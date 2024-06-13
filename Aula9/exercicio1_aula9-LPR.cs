using System;
class HelloWorld {
  
  public struct Produto {
      public string Nome;
      public int Codigo;
      public double Preco;
      public int Quantidade;
  }  
  static void Main() {
    Produto[] produtos = new Produto[3];
    double valor_total = 0;
    for(int i = 0; i < 3; i++){
        Console.WriteLine("Digite o nome do produto");
        produtos[i].Nome = Console.ReadLine();
        Console.WriteLine("Digite o código do produto");
        produtos[i].Codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço do produto");
        produtos[i].Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade do produto");
        produtos[i].Quantidade = int.Parse(Console.ReadLine());
    }
    valor_total = (produtos[0].Preco * produtos[0].Quantidade) + (produtos[1].Preco * produtos[1].Quantidade) + (produtos[2].Preco * produtos[2].Quantidade);  
    Console.WriteLine($"O valor total em estoque é {valor_total}");
  }
}