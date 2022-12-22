// Prova de POO 1º Bimestre 2022.2

using System;
using System.Collections;
using Modelo;
//using Negocio;

// Questão 04

namespace visao {
  public class Program {
    public static void Main() {
      Jogador j1 = new Jogador("Verinha", 9, 3);
      Jogador j2 = new Jogador("", -1, 0);
      Jogador j3 = new Jogador("Dona Dalva", 4, -1);
      Jogador j4 = new Jogador("Cleuza", 2, 2);
  
      Equipe tabajara = new Equipe("Tabajara");
      
      tabajara.Inserir(j1);
      tabajara.Inserir(j2);
      tabajara.Inserir(j3);
      tabajara.Inserir(j4);
      
      Console.WriteLine($"Equipe:\n{tabajara}\n");
  
      Console.WriteLine($"Ordenados:");
      Jogador[] ordenados = tabajara.Listar();
      foreach (Jogador jogador in ordenados)
        Console.WriteLine($"{jogador}\n");
  
      Console.WriteLine($"Artilheiros:");
      Jogador[] artilheiros = tabajara.Artilheiros();
      foreach (Jogador jogador in artilheiros)
        Console.WriteLine($"{jogador}\n");
  
      Console.WriteLine($"Camisas:");
      Jogador[] camisas = tabajara.Camisas();
      foreach (Jogador jogador in camisas)
        Console.WriteLine($"{jogador}\n");
    }
  }
}
