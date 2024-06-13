#include <iostream>
#include <array>
#include <string>
using namespace std;

    struct Livro {
      string Titulo;
      string Autor;
      int AnoPublicacao;
      int NumeroPaginas;
      double Preco;
    };
  
 int main()
{
    array<Livro,3> livros;
    double preco_total = 0;
    double soma_paginas = 0;
    double media_paginas = 0;
    
    for(int i = 0; i < 3; i++){
        cout << "Digite o titulo do livro" << endl;
        cin >> livros[i].Titulo;
        cout << "Digite o autor do livro" << endl;
        cin >> livros[i].Autor;
        cout << "Digite o ano de publicação do livro" << endl;
        cin >> livros[i].AnoPublicacao;
        cout << "Digite o número de páginas do livro" << endl;
        cin >> livros[i].NumeroPaginas;
        cout << "Digite o preço do livro" << endl;
        cin >>livros[i].Preco;
        
        preco_total += livros[i].Preco;
        soma_paginas += livros[i].NumeroPaginas;
    }
    //preco_total = (livros[0].Preco + livros[1].Preco + livros[2].Preco);
    media_paginas = (soma_paginas/3);
    cout << "O preço total dos livros cadastrados são: R$" << preco_total << endl;
    cout << "A média de páginas dos livros é: " << media_paginas << endl;
    return 0;
}