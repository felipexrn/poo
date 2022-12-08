// Prova de POO 1º Bimestre 2022.2

using System;
using System.Collections;

// Questão 01

public class Jogador : IComparable{
  private string nome = "Não declarado";
  private int camisa;
  private int numGols;
  public string Nome {
    set {if (value != "") nome = value;}
    get {return nome;}
  }
  public int Camisa {
    set {if (value > 0) camisa = value;}
    get {return camisa;}
  }
  public int NumGols {
    set {if (value >= 0) numGols = value;}
  }  
  public Jogador() {}
  public Jogador(string n, int c, int g) {
    this.Nome = n;
    this.Camisa = c;
    this.NumGols = g;
  }
  public override string ToString() {
    return $"Nome: {nome}\n" +
      $"Camisa: {camisa}\n" +
      $"Numero de gols: {numGols}";
  }
  public int CompareTo(object obj) {
    Jogador j2 = (Jogador) obj;
    return this.nome.CompareTo(j2.nome);
  }
}

// Questão 04

public class Program {
  public static void Main() {
    
    Jogador j1 = new Jogador("Verinha", 9, 3);
    Jogador j2 = new Jogador("", -1, 0);
    Jogador j3 = new Jogador("Dona Dalva", 4, -1);
    Jogador j4 = new Jogador("Cleuza", 2, 2);

    Jogador[] jogadores = new Jogador[4];
    
    jogadores[0] = j1;
    jogadores[1] = j2;
    jogadores[2] = j3;
    jogadores[3] = j4;
    
    Array.Sort(jogadores);
    
    foreach (Jogador jogador in jogadores)
      Console.WriteLine($"{jogador}\n");
  }
}