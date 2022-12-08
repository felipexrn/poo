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

// Questão 02

public class Equipe {
  private string pais;
  private int max = 22;
  private Jogador[] jogs;
  private int qtd;
  private int i;
  public Jogador[]
  public int Max {set{if (value > 0) max = value;}}
  public string Pais {
    set {if (value != "") pais = value;}
    get {return pais;}
  }
  public Equipe(string n, int m) {
    this.Pais = n;
    this.Max = m;
  }
  public void Inserir(Jogador j) {
    jogs[this.qtd] = j;
    this.qtd++;
  }
  public Jogador[] Listar() {
    Jogador[] alfab = new Jogador[this.qtd];
    Array.Sort(jogs);
    foreach(Jogador j in alfab)
      j = jogs[this.i];
    this.i = 0;
    return jogs;
  }
  public Jogador[] Artilheiros() {
    Jogador[] artilheiros = new Jogador[3];
    CompArt comparador = new CompArt();
    Array.Sort(jogs, comparador);
    foreach(Jogador art in artilheiros)
      art = jogs[this.i];
    this.i = 0;
    return artilheiros;
  }
  public Jogador[] Camisas() {
    Jogador[] camisas = new Jogador[this.qtd];
    CompCam comparador = new CompCam();
    Array.Sort(jogs, comparador);
    foreach(Jogador cam in camisas)
      cam = jogs[this.i];
    this.i = 0;
    return camisas;
  }
  public override string ToString() {
    return $"Pais: {pais}\n" +
      $"Quantidade de jogadores: {qtd}";
  }
}

// Questão 03

public class CompArt : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.NumGols.CompareTo(j2.NumGols);
  }
}

public class CompCam : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador j1 = (Jogador) obj1;
    Jogador j2 = (Jogador) obj2;
    return j1.Camisa.CompareTo(j2.Camisa);
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

    Equipe tabajara = new Equipe("Tabajara", 4);
    
    tabajara.Inserir(j1);
    tabajara.Inserir(j2);
    tabajara.Inserir(j3);
    tabajara.Inserir(j4);
    
    Console.WriteLine(tabajara);

    foreach (Jogador jogador in jogadores)
      Console.WriteLine($"{jogador}\n");
    
  }
}