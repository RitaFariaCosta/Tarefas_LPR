#include <iostream>
using namespace std;

int main() {
    int num[10];  
    int numero;
    int cont_ocorrencias = 0;
    
    for (int i = 0; i < 10; i++) {
        cout << "Número " << i + 1 << ": ";
        cin >> num[i];
    }
    
    cout << "Digite um número que você gostaria de pesquisar no vetor: ";
    cin >> numero;

    cout << "O número " << numero << " aparece nas posições: ";
    for (int i = 0; i < 10; i++) {
        if (num[i]  ==  numero) {
            cout << i << " ";
            cont_ocorrencias++;
        }
    }
    
    if(cont_ocorrencias > 0){
        cout << "\nOcorrências: " << cont_ocorrencias << endl;
        } else {
            cout << "\nEste número não existe no vetor" << endl;
        }
    
    return 0;
}