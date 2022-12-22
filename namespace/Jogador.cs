// Questão 01
using System;
using System.Collections;
namespace Modelo {
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
      get {return numGols;}
    }  
    public Jogador() {}
    public Jogador(string n, int c, int g) {
      this.Nome = n;
      this.Camisa = c;
      this.NumGols = g;
    }
    public override string ToString() {
      return $"  Nome: {nome}\n" +
        $"  Camisa: {camisa}\n" +
        $"  Numero de gols: {numGols}";
    }
    public int CompareTo(object obj) {
      Jogador j2 = (Jogador) obj;
      return this.nome.CompareTo(j2.nome);
    }
  }
}