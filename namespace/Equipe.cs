// Questão 02
using System;
using System.Collections;
namespace Equipe {
  public class Equipe {
    private string pais;
    private Jogador[] jogs;
    private int qtd;
    private int i;
    public Jogador[] Jogs {set{jogs = value;}}
    public string Pais {
      set {if (value != "") pais = value;}
      get {return pais;}
    }
    public Equipe(string n, Jogador[] j) {
      this.Pais = n;
      this.Jogs = j;
    }
    public void Inserir(Jogador j) {
      jogs[this.qtd] = j;
      this.qtd++;
    }
    public Jogador[] Listar() {
      Jogador[] alfab = new Jogador[this.qtd];
      Array.Sort(jogs);
      foreach(Jogador j in alfab) {
        alfab[this.i] = jogs[this.i];
        this.i++;
      }
      this.i = 0;
      return jogs;
    }
    public Jogador[] Artilheiros() {
      Jogador[] artilheiros = new Jogador[3];
      CompArt comparador = new CompArt();
      Array.Sort(jogs, comparador);
      Array.Reverse(jogs);
      foreach(Jogador art in artilheiros) {
        artilheiros[this.i] = jogs[this.i];
        this.i++;
      }
      this.i = 0;
      return artilheiros;
    }
    public Jogador[] Camisas() {
      Jogador[] camisas = new Jogador[this.qtd];
      CompCam comparador = new CompCam();
      Array.Sort(jogs, comparador);
      foreach(Jogador cam in camisas) {
        camisas[this.i] = jogs[this.i];
        this.i++;
      }
      this.i = 0;
      return camisas;
    }
    public override string ToString() {
      return $"  Pais: {pais}\n" +
        $"  Quantidade de jogadores: {qtd}";
    }
  }
}