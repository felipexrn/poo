using System;
public class Pais {
  private string nome = "Não declarado";
  private int populacao = 0;
  public Pais() {}
  public Pais(string nome, int populacao) {
    if (nome != "") this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public string GetNome() {
    return nome;
  }
  public int GetPopulacao() {
    return populacao;
  }
  public override string ToString() {
    return $"País = {nome}\nPopulação = {populacao}";
  }
}
public class Program {
  public static void Main() {
    Pais[] paises = new Pais[10]; 
    int maiorPopulacao = 0;
    int indicePais = 0;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine($"Digite o nome do país {i+1}/10 e na próxima linha a sua populcação.");
      paises[i] = new Pais(Console.ReadLine(),int.Parse(Console.ReadLine()));
      if (paises[i].GetPopulacao() > maiorPopulacao) {
        maiorPopulacao = paises[i].GetPopulacao();
        indicePais = i;
      }
    }
    Console.WriteLine(paises[indicePais].ToString());
  }
}