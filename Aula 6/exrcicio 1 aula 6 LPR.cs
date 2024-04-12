/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    //variaveis
    int quantidade_num;
    double qtd = 0;
    int num_analisado;
    int acumulador = 0; // soma dos numeros pares
    int contador = 0; //quantidade de numero par
    double media;
    
    Console.WriteLine("Digite a quantidade de números que serão digitados");
    quantidade_num = int.Parse(Console.ReadLine());
    
    while(contador<quantidade_num){
    Console.WriteLine("Digite o número");
    num_analisado = int.Parse(Console.ReadLine());
    
    if(num_analisado%2 == 0){
        acumulador += num_analisado;
        qtd++;
    }
    contador++;
    }
    media = acumulador/qtd;
    Console.WriteLine("Média: " + media);
  }
}