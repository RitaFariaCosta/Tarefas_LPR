using System;
class HelloWorld {
  static void Main() {
      string cidade_origem;
      string cidade_destino;
      int indice_origem = -1;
      int indice_destino = -1;
      int distancia = 0;
      
      int[,] matriz = { {0, 524, 521, 882}, {524, 0, 434, 586}, {521, 434, 0, 429}, {882, 586, 429, 0} };
      
      while(true){
          
          Console.WriteLine("\nDigite a primeira cidade: ");
          Console.WriteLine("Opções: Vitoria, Belo Horizonte, Rio de Janeiro e Sao Paulo ");
          cidade_origem = Console.ReadLine();
          
          if (cidade_origem == "Vitoria"){
            indice_origem = 0;  
          }
          else if(cidade_origem == "Belo Horizonte"){
            indice_origem = 1;  
          }
          else if(cidade_origem == "Rio de Janeiro"){
            indice_origem = 2;  
          }
          else if(cidade_origem == "Sao Paulo"){
            indice_origem = 3;  
          }
          else{
            Console.WriteLine("Opção inválida");
            break;
          }
           
          Console.WriteLine("Digite a segunda cidade: ");
          cidade_destino = Console.ReadLine();
          
          if (cidade_destino == "Vitoria"){
            indice_destino = 0;  
          }
          else if(cidade_destino == "Belo Horizonte"){
            indice_destino = 1;  
          }
          else if(cidade_destino == "Rio de Janeiro"){
            indice_destino = 2;  
          }
          else if(cidade_destino == "Sao Paulo"){
            indice_destino = 3;  
          }
          else{
            Console.WriteLine("Opção inválida"); 
          }
          
          if(cidade_origem == cidade_destino){
              break;
          }
          else{
            distancia = matriz[indice_origem, indice_destino];
            Console.WriteLine($"A distância entre {cidade_origem} e {cidade_destino} é {distancia}km");
          }
          
      }
  }
}