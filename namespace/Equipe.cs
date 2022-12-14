// Questão 02
using System;
using System.Collections;
namespace Equipe {
  public class Equipe {
    private string pais;
    private Jogador[] jogs = new Jogador[22];
    private int qtd;
    private int i;
    public Jogador[] Jogs {set{jogs = value;}}
    public string Pais {
      set {if (value != "") pais = value;}
      get {return pais;}
    }
    public Equipe(string n) {
      this.Pais = n;
    }
    public void Inserir(Jogador j) {
      jogs[this.qtd] = j;
      this.qtd++;
    }
    public Jogador[] Listar() {
      Jogador[] alfab = new Jogador[this.qtd];
      Array.Copy(jogs, alfab, this.qtd);
      Array.Sort(alfab);
      return alfab;
    }
    public Jogador[] Artilheiros() {
      Jogador[] artilheiros = new Jogador[3];
      Jogador[] time = new Jogador[this.qtd];
      Array.Copy(jogs, time, this.qtd);
      CompArt comparador = new CompArt();
      Array.Sort(time, comparador);
      Array.Reverse(time);
      foreach(Jogador art in artilheiros) {
        artilheiros[this.i] = time[this.i];
        this.i++;
      }
      this.i = 0;
      return artilheiros;
    }
    public Jogador[] Camisas() {
      Jogador[] camisas = new Jogador[this.qtd];
      Array.Copy(jogs, camisas, this.qtd);
      CompCam comparador = new CompCam();
      Array.Sort(camisas, comparador);
      return camisas;
    }
    public override string ToString() {
      return $"  Pais: {pais}\n" +
        $"  Quantidade de jogadores: {qtd}";
    }
  }
}