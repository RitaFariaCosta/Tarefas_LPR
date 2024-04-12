/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    int num_digitado;
    int tentativas = 0;
    
    Random numAleatorio = new Random();
    int valorInteiro = numAleatorio.Next(1,100);
    
    Console.WriteLine("Tente adivinhar o número");
    num_digitado = int.Parse(Console.ReadLine());
    tentativas ++;

    do{
        if(num_digitado > valorInteiro){
        Console.WriteLine("Chutou alto");
        }
        else if(num_digitado < valorInteiro){
        Console.WriteLine("Chutou baixo");
        }
        
    Console.WriteLine("Tente adivinhar o número novamente");
    num_digitado = int.Parse(Console.ReadLine());
    
    tentativas ++;
    }while(num_digitado != valorInteiro);
    
    Console.WriteLine("Você acertou!");
    Console.WriteLine("Tentativas: " + tentativas);
  }
}