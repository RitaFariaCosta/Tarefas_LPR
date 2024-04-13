/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
// EXERCICIO 2 AULA 7 LPR 
#include <iostream>
using namespace std;

  double exercicio1(int quant)
 {
    int soma = 0;
    int contador = 0;
    
    while (quant > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }
        quant--;
    }
    
    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        return media;
    } 
    else {
        cout << "Nenhum número par foi digitado." << endl;
        return 0;
    }
 }  
  
  int exercicio3(int começo, int final, int divis)
  {
    int soma = 0;
    
    for (int i = começo; i <= final; i++) {
        // Verificando se o número é ímpar e múltiplo de divis
        if (i % 2 != 0 && i % divis == 0) {
            soma += i; // Adicionando o número à soma
        }
    }
    return soma;
  }
  
  int exercicio4(int num)
  {
    int quadrado = num * num;
    int somaDigitos = 0;

    while (quadrado > 0) {
        somaDigitos += quadrado % 10; // Adicionando o último dígito à soma
        quadrado /= 10; // Removendo o último dígito
    }
    return somaDigitos;
  }

int main()
{
    int opcao;
    cout<<"Escolha uma opção" << endl;
    cout<<"1-Exercício 1" << endl;
    cout<<"2-Exercício 3" << endl;
    cout<<"3-Exercício 4" << endl;
    cin >> opcao;
    
    int quantidade;
    double media;
    
    int inicio, fim, divisor;
    int somatoria;
    
    int numero;
    int soma;
    
    switch(opcao){
        case 1:
        cout << "Digite a quantidade de números a serem inseridos: ";
        cin >> quantidade;
        media = exercicio1(quantidade);
        cout << "A média dos números pares é: " << media << endl;
        break;
        
        case 2:
        cout << "Digite o valor inicial do conjunto" << endl;
        cin >> inicio;
        cout << "Digite o valor do final do conjunto" << endl;
        cin >> fim;
        cout << "Digite o divisor" << endl;
        cin >> divisor;
        somatoria = exercicio3(inicio,fim,divisor);
        cout << "A soma dos números ímpares múltiplos de" << divisor << " de " << inicio << "a" << fim <<" é: " << somatoria << endl;
        break;
        
        case 3:
        cout << "Digite um número: ";
        cin >> numero;
        soma = exercicio4(numero);
        cout << "A soma dos dígitos do quadrado de " << numero << " é: " << soma << endl;
        break;
        
        default:
        cout << "Opção inválida" << endl;
        break;
    }
    return 0;
}