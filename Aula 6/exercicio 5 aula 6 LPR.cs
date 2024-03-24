using System;
class HelloWorld {
  static void Main() {
      
      //variaveis
      int num_horas_dia;
      int dias_necessarios = 0;
      int semanas_necessarias = 0; //1 semana = 5 dias
      double meses_necessarios = 0; //1 mes = 4,5 semanas
      int total_horas = 0;
      int total_horas_semana; //5 * numero de horas por dia de treinamento
      
      //entrada
      Console.WriteLine("Insira o número de horas de treinamento por dia");
      num_horas_dia = int.Parse(Console.ReadLine());
      
      //estrutura de repetição
      while(total_horas < 1000){
          
        total_horas_semana = 5 * num_horas_dia;  
        total_horas += total_horas_semana; 
        
        dias_necessarios = 1000/num_horas_dia;
        semanas_necessarias = dias_necessarios/5; // ou semanas_necessarias++;
        meses_necessarios = semanas_necessarias/4.5;
        // Console.WriteLine(total_horas);
      }
      
      //saidas
      Console.WriteLine($"Dias necessários para atingir 1000 horas de treinamento: {dias_necessarios}");
      Console.WriteLine($"Semanas necessários para atingir 1000 horas de treinamento: {semanas_necessarias}");
      Console.WriteLine($"Meses necessários para atingir 1000 horas de treinamento: {meses_necessarios:F1}");
  }
}