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
    int A, B;
    cout<<"Digite um número inteiro" << endl;
    cin >> A;
    
    cout<<"Digite um número inteiro" << endl;
    cin >> B;
    
    if(A % B == 0 || B % A == 0){
    cout << "Os números digitados são múltiplos" << endl;
    }
    else {
    cout << "Os números digitados não são múltiplos" << endl;    
    }

    return 0;
}