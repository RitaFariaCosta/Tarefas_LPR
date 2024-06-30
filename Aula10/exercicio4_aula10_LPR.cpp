#include <iostream>
#include <map>
#include <algorithm> 
using namespace std;

int main()
{
    map<string, float> populacoesDasCidades;
    int quantidade;
    string nome;
    float populacao, soma = 0;
    
    cout<<"Digite a quantidade de cidades: ";
    cin >> quantidade;
    
    for(int i = 0; i < quantidade; i++){
        cout<<"\nDigite o nome da cidade: ";
        cin >> nome;
        cout<<"Digite a população da cidade: ";
        cin >> populacao;
      populacoesDasCidades.insert({ nome, populacao}); 
      soma += populacao;
    }
     float media = soma/quantidade;
     
     cout << "\nCidades com população acima da média: " << endl;
    for(auto cidade : populacoesDasCidades){
        if(cidade.second > media){
           cout << cidade.first << " com população de " << cidade.second << endl;
        }
    }
    
    auto cidadeMaisPopulosa = populacoesDasCidades.begin();
    auto cidadeMenosPopulosa = populacoesDasCidades.begin();
    
    for (auto it = populacoesDasCidades.begin(); it != populacoesDasCidades.end(); it++) {
        if (it->second > cidadeMaisPopulosa->second) {
            cidadeMaisPopulosa = it;
        }
        if (it->second < cidadeMenosPopulosa->second) {
            cidadeMenosPopulosa = it;
        }
    }
    cout << "\nCidade mais populosa: " << cidadeMaisPopulosa->first << " com população de " << cidadeMaisPopulosa->second << endl;
    cout << "Cidade menos populosa: " << cidadeMenosPopulosa->first << " com população de " << cidadeMenosPopulosa->second << endl;
    
    cout << "\nDigite uma população para remover: ";
    int numRemover;
    cin >> numRemover;
    
    for (auto it = populacoesDasCidades.begin(); it != populacoesDasCidades.end();) {
        if (it->second == numRemover) {
            it = populacoesDasCidades.erase(it);
        } 
        else {
            it++;
        }
    }
    cout << endl;
    for (auto cidade : populacoesDasCidades)
    {
        
      cout << "Cidade: " << cidade.first << ", População: " << cidade.second << endl;
    }
    return 0;
}