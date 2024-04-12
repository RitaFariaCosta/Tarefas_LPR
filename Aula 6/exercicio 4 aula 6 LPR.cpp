#include <iostream>
using namespace std;

int main()
{
    int num_digitado;
    int soma = 0;
    int quadrado;
    
    cout << "Digite um numero" << endl;
    cin >> num_digitado;
    
    quadrado = num_digitado * num_digitado;
    
    while(quadrado != 0){
     soma += quadrado % 10; // soma = soma + o ultimo digito do quadrado
     quadrado = quadrado/10; // remove o ultimo digito do quadrado
    }
    cout << "A soma dos dígitos do quadrado do número digitado é: " << soma << endl;

    return 0;
}