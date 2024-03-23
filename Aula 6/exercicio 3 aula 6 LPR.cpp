#include <iostream>
using namespace std;

int main()
{
    int soma = 0;
    
    for(int i=50; i<=500;i++)
    {
        if(i % 2 == 1 && i % 3 == 0)
        {
        soma += i;
        }
    }
    cout << "A soma dos números é: " << soma << endl;

    return 0;
}