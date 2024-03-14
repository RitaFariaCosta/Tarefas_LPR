/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>
using namespace std;

int main()
{
    int numero;
    cout<<"Digite um número inteiro" << endl;
    cin >> numero;
    
    if(numero % 2 == 0){
    cout << "O número digitado é par" << endl;
    }
    else {
    cout << "O número digitado é ímpar" << endl;    
    }

    return 0;
}