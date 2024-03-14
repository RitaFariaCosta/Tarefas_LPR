/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int opcao;
    Console.WriteLine("Escolha uma classe de personagem");
    Console.WriteLine("1-Guerreira");
    Console.WriteLine("2-Mago");
    Console.WriteLine("3-Arqueira");
    opcao = Convert.ToInt32(Console.ReadLine());
    
    switch(opcao)
    {
    case 1:
    Console.WriteLine("As habilidades especiais são: Ataque Pesado, Defesa Total");
    break;
    
    case 2:
    Console.WriteLine("As habilidades especiais são: Bola de Fogo, Escudo de Gelo");
    break;
    
    case 3:
    Console.WriteLine("As habilidades especiais são: Flecha Precisa, Disparo Triplo");
    break;
    
    default:
    Console.WriteLine("Opção inválida");
    break;
    }
  }
}