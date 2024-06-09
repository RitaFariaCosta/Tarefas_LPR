#include <iostream>
using namespace std;

int main() {
    int num[10];   
    int par[10];     
    int impar[10];   
    int cont_par = 0;   
    int cont_impar = 0; 
    
    for (int i = 0; i < 10; i++) {
        cout << "Número " << i + 1 << ": ";
        cin >> num[i];
    }

    for (int i = 0; i < 10; i++) {
        if (num[i] % 2 == 0) {
            par[cont_par++] = num[i];
        } else {
            impar[cont_impar++] = num[i];
        }
    }

    cout << "Números pares: ";
    for (int i = 0; i < cont_par; i++) {
        cout << par[i] << " ";
    }
    
    cout << "\nNúmeros ímpares: ";
    for (int i = 0; i < cont_impar; i++) {
        cout << impar[i] << " ";
    }

    return 0;
}