#include <iostream>
#include <algorithm>
#include <unordered_map>
#include <list>
using namespace std;


 int main() {
    // Semente para gerar números aleatórios
    srand(time(0));

    // Cria uma lista de 100 números aleatórios
    list<int> numeros;

    for (int i = 0; i < 100; i++) {
        numeros.push_back(rand() % 1000); // Números entre 0 e 999
    }

    // Imprime a lista original
    cout << "Lista original:" << endl;
    for (int num : numeros) {
        cout << num << " " << endl;
    }
    
    // Ordena a lista em ordem crescente
    numeros.sort();
    
    // Imprime a lista ordenada
   cout << "Lista em ordem crescente:" << endl;
    for (int num : numeros) {
        cout << num << " " << endl;
    }


    // Remove os números pares da lista
    numeros.erase(remove_if(numeros.begin(), numeros.end(), [](int num) { return num % 2 == 0; }), numeros.end());
    
    // Imprime a lista sem números pares
    cout << "Lista sem números pares:" << endl;
    for (int num : numeros) {
        cout << num << " " << endl;
    }
   
    // Verifica quais números se repetem
    unordered_map<int, int> freq;
    for (int num : numeros) {
        freq[num]++;
    }
    bool repetido = false;
    
    for (auto& entry : freq) {
        if (entry.second > 1) {
            cout << "Número " << entry.first << " se repete " << entry.second << " vezes." << endl;
            repetido = true;
        }
    }
    if (!repetido) {
        cout << "Não há números repetidos." <<endl;
    }

    return 0;
}
