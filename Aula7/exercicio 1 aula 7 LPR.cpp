//Exercicio 1 aula 7 LPR
#include <iostream>
using namespace std;
int numero;

    int numeroReverso(int num)
    {
    int num_reverso = 0;
    while(num > 0) {
    int ultimo_digito = num % 10;
    num_reverso = num_reverso * 10 + ultimo_digito;
    num /= 10; // = num = num/10;
    }
    return num_reverso;
    }

    int main()
    {
    cout<<"Digite um número" << endl;
    cin >> numero;
    int numeroreverso = numeroReverso(numero); 
    cout<<"O reverso do número " << numero << " é: " << numeroreverso << endl;
    
    return 0;
    }