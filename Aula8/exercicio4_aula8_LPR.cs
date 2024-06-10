using System;
class HelloWorld {
  static void Main() {
      
      int[,] matrizA = new int[3, 3];
      int[,] matrizB = new int[3, 3];
      int[,] matrizFinal = new int[3, 3];
      
      Console.WriteLine("Digite os valores da matriz A");
      PreencherMatriz(matrizA);
      
      Console.WriteLine("Digite os valores da matriz B");
      PreencherMatriz(matrizB);
      
      for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizFinal[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    matrizFinal[i, j] += matrizA[i, k] * matrizB[k, j];
                }
            }
        }
        Console.WriteLine("Matriz Resultado (A*B):");
        ImprimirMatriz(matrizFinal);
    }
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor para [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
  }
